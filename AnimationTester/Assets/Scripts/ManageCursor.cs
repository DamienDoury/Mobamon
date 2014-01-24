using UnityEngine;
using System.Collections;

public class ManageCursor : MonoBehaviour
{
	private PokemonController controller = null;
	private SelectedMove selectedMove;
	private GameObject hoverEntity;

	private Texture2D hand;
	private Vector2 handPos;
	private Texture2D single;
	private Vector2 singlePos;
	private Texture2D singleAlly;
	private Vector2 singleAllyPos;
	private Texture2D singleEnemy;
	private Vector2 singleEnemyPos;

	// Use this for initialization
	void Start()
	{
		hand = (Texture2D)Resources.Load("GUI/Cursor/Hand", typeof(Texture2D));
		single = (Texture2D)Resources.Load("GUI/Cursor/SingleTarget", typeof(Texture2D));
		singleAlly = (Texture2D)Resources.Load("GUI/Cursor/SingleTarget_Ally", typeof(Texture2D));
		singleEnemy = (Texture2D)Resources.Load("GUI/Cursor/SingleTarget_Enemy", typeof(Texture2D));
		
		handPos = new Vector2(9f, 12f);
		singlePos = new Vector2(24f, 24f);
		singleAllyPos = new Vector2(24f, 24f);
		singleEnemyPos = new Vector2(24f, 24f);

		GetController();
		GetControllerInfos();
	}
	
	void Update()
	{
		GetControllerInfos();

		if(!controller)
			return;

		if(!(selectedMove != null && !selectedMove.IsLaunched()))
		{
			Cursor.SetCursor(hand, handPos, CursorMode.ForceSoftware);
		}
		else if(selectedMove != null && !selectedMove.IsLaunched())
		{
			TargetType targetType = selectedMove.info.targetType;
			
			if(targetType == TargetType.Area)
			{
				Cursor.SetCursor(singleEnemy, singleEnemyPos, CursorMode.ForceSoftware);
			}
			else
			{
				if(hoverEntity)
				{
					if(targetType == TargetType.Self && hoverEntity.Equals(gameObject))
					{
						Cursor.SetCursor(singleAlly, singleAllyPos, CursorMode.ForceSoftware);
					}
					else if(targetType == TargetType.Enemy && !hoverEntity.Equals(gameObject))
					{
						Cursor.SetCursor(singleEnemy, singleEnemyPos, CursorMode.ForceSoftware);
					}
					else
					{
						Cursor.SetCursor(single, singlePos, CursorMode.ForceSoftware);
					}
				}
				else
				{
					Cursor.SetCursor(single, singlePos, CursorMode.ForceSoftware);
				}
			}
		}
	}

	void GetController()
	{
		GameObject pokemon = GameObject.Find("Pokemon").GetComponentInChildren(typeof(PokemonController)).gameObject;
		PokemonController temp = pokemon.GetComponent<PokemonController>();
		controller = temp;
	}

	void GetControllerInfos()
	{
		if(controller == null)
		{
			GetController();
			return;
		}

		selectedMove = controller.selectedMove;
		hoverEntity = controller.hoverEntity;
	}
}
