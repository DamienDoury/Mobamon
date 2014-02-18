using UnityEngine;
using System.Collections;
using Mobamon.Pokemon.Player;
using Mobamon.Pokemon.Classes;
using Mobamon.Database;
using Mobamon.Database.Enums;

namespace Mobamon.UI
{
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

		private Plane groundPlane; // The plane (x, z) at level zero.
		private Transform rangeIndicator; // Container of the range indicator visuals. Only used for the rotation.
		private GameObject ri_disk; // Preloaded range indicator type.
		private GameObject ri_cone; // Preloaded range indicator type.
		private float body_radius = 0f; // Radius of the navmesh agent. Used to increase the range of some spells.
		private string lastSelectedMove = "";

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

			groundPlane = new Plane(Vector3.up, Vector3.forward);
			ri_disk = (GameObject)Resources.Load("RangeIndicators/disk");
			ri_cone = (GameObject)Resources.Load("RangeIndicators/cone_10deg");

			GetControllerInfos();
		}
		
		void Update()
		{
			GetControllerInfos();

			if(!controller)
				return;

			DisplayCursor();
			DisplayRangeIndicator();
		}

		void GetController()
		{
			GameObject pokemon = GameObject.FindGameObjectWithTag("CameraTarget");
			controller = pokemon.GetComponent<PokemonController>();

			if(controller != null && body_radius == 0)
			{
				body_radius = controller.nav.radius;

				GameObject temp = (GameObject)Instantiate(new GameObject(), controller.transform.position, Quaternion.identity);
				temp.name = "RangeIndicator";
				temp.transform.parent = controller.transform;
				rangeIndicator = temp.transform;
			}
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

		void DisplayCursor()
		{
			if(!(selectedMove != null && !selectedMove.IsLaunched()))
			{
				Cursor.SetCursor(hand, handPos, CursorMode.ForceSoftware);
			}
			else if(selectedMove != null && !selectedMove.IsLaunched())
			{
				MoveTargetKind targetType = selectedMove.info.TargetKind;
				
				if(targetType == MoveTargetKind.Area)
				{
					Cursor.SetCursor(singleEnemy, singleEnemyPos, CursorMode.ForceSoftware);
				}
				else
				{
					if(hoverEntity)
					{
						if(targetType == MoveTargetKind.Single && hoverEntity.Equals(gameObject))
						{
							Cursor.SetCursor(singleAlly, singleAllyPos, CursorMode.ForceSoftware);
						}
						else if(targetType == MoveTargetKind.Single && !hoverEntity.Equals(gameObject))
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

		void DisplayRangeIndicator()
		{
			if(selectedMove != null && !selectedMove.IsLaunched())
			{
				bool isSelfOnly = (PokemonRelation.Self & selectedMove.info.AllowedTargets) == PokemonRelation.Self
					&& (PokemonRelation.Ally & selectedMove.info.AllowedTargets) == 0
						&& (PokemonRelation.Enemy & selectedMove.info.AllowedTargets) == 0;
				
				if(isSelfOnly)
					return;

				if(lastSelectedMove != selectedMove.name && lastSelectedMove != "")
				{
					DestroyRangeIndicator();
					//return;
				}

				MoveShape shape = Attackdex.move[selectedMove.name].Shape;

				if(rangeIndicator.childCount == 0)
				{
					Object obj = null;
					lastSelectedMove = selectedMove.name;

					if(shape == MoveShape.Point)
					{
						obj = (Object)ri_disk;
					}
					else if(shape == MoveShape.Cone)
					{
						obj = (Object)ri_cone;
					}

					if(obj != null)
					{
						GameObject ri = (GameObject)GameObject.Instantiate((Object)obj, rangeIndicator.position, rangeIndicator.rotation);
						ri.transform.parent = rangeIndicator;

						if(shape == MoveShape.Cone)
							ri.transform.position += rangeIndicator.forward * body_radius;

						SpriteRenderer sprRend = (SpriteRenderer)ri.GetComponentInChildren(typeof(SpriteRenderer));
						float factor = (shape == MoveShape.Cone ? 1f : 0.5f); // Only the visual of the cone represents the radius of the attack, the other images (like the disk) represents the diameter.
						float offset = (shape == MoveShape.Point || shape == MoveShape.Projectile ? body_radius * 100f : 0f);

						float spriteHeight = sprRend.sprite.textureRect.height * factor;
						float range = Attackdex.move[selectedMove.name].Range + offset;

						float ratio = range / spriteHeight;
						ri.transform.localScale = new Vector3(ratio, 1f, ratio);
					}
				}

				if(rangeIndicator.childCount > 0)
				{
					if(shape == MoveShape.Cone && controller.myCam != null)
					{
						Ray ray = controller.myCam.ScreenPointToRay(Input.mousePosition);

						float rayDistance = 0f;
						groundPlane.Raycast(ray, out rayDistance);
						Vector3 target = ray.GetPoint(rayDistance);
						rangeIndicator.transform.LookAt(target);
					}
				}
			}
			else
			{
				DestroyRangeIndicator();
			}
		}

		void DestroyRangeIndicator()
		{
			lastSelectedMove = "";
			
			foreach(Transform child in rangeIndicator)
				Destroy(child.gameObject);
		}
	}
}