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
        public GameObject ri_disk; // Preloaded range indicator type.
        public GameObject ri_cone; // Preloaded range indicator type.
        public Texture2D hand;
        public Texture2D single;
        public Texture2D singleAlly;
        public Texture2D singleEnemy;

		private PokemonController controller = null;
		private SelectedMove selectedMove;
		private GameObject hoverEntity;
		private Transform pkmnList;

		private Vector2 handPos;
		private Vector2 singlePos;
		private Vector2 singleAllyPos;
		private Vector2 singleEnemyPos;

		private Plane groundPlane; // The plane (x, z) at level zero.
		private Transform rangeIndicator; // Container of the range indicator visuals. Only used for the rotation.
		private float body_radius = 0f; // Radius of the navmesh agent. Used to increase the range of some spells.
		private string lastSelectedMove = "";

		// Use this for initialization
		void Start()
		{
			pkmnList = GameObject.Find("Pokemon").transform;
			
			handPos = new Vector2(9f, 12f);
			singlePos = new Vector2(24f, 24f);
			singleAllyPos = new Vector2(24f, 24f);
			singleEnemyPos = new Vector2(24f, 24f);

			groundPlane = new Plane(Vector3.up, Vector3.forward);

			GetControllerInfos();
		}
		
		void Update()
		{
			GetControllerInfos();

			if(!controller)
				return;

			DisplayCursor();
			DisplayRangeIndicator();
			HightlightEntities();
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
				bool isSelfOnly = ((int)PokemonRelation.Self ^ (int)selectedMove.info.AllowedTargets) == 0;
				
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
						foreach(SpriteRenderer child in ri.GetComponentsInChildren<SpriteRenderer>())
							child.gameObject.layer = LayerMask.NameToLayer("Terrain");

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
						target = new Vector3(target.x, rangeIndicator.transform.position.y, target.z);
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

		void HightlightEntities()
		{
			GameObject caster = controller.gameObject;

			foreach(Transform pkmn in pkmnList)
			{
				if(!pkmn.gameObject.activeSelf)
					continue;

				Color outlineColor = Color.black;

				/*if(hoverEntity == pkmn.gameObject)
					outlineColor = Color.white;*/

				if(selectedMove != null && !selectedMove.IsLaunched())
				{
					float range = selectedMove.info.Range;
					SphereCollider pkmnCollider = (SphereCollider)pkmn.GetComponent(typeof(Collider));

					if(Vector3.Magnitude(pkmn.position - caster.transform.position) <= selectedMove.info.Range / 100f + controller.nav.radius + pkmnCollider.radius)
					{
						if(((int)controller.GetRelation(pkmn.gameObject) & (int)selectedMove.info.AllowedTargets) != 0)
						{
							outlineColor = Color.white;

							if(selectedMove.info.TargetKind == MoveTargetKind.Single && hoverEntity == pkmn.gameObject)
								outlineColor = Color.red;
						}
					}
				}

				Renderer rend = (Renderer)pkmn.GetComponentInChildren(typeof(Renderer));
				foreach(Material mat in rend.materials)
				{
					mat.SetColor("_OutlineColor", outlineColor);
				}
			}
		}
	}
}