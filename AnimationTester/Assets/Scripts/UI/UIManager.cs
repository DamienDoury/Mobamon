using UnityEngine;
using System.Collections;
using Mobamon.Pokemon.Player;

namespace Mobamon.UI
{
	public class UIManager : MonoBehaviour
	{
		private Texture spellBarTexture;
		private Texture healthBarTexture;
		private Texture healthPatternTexture;

		private Camera cam = null;
		public Vector3 pos;

		protected void Start()
		{
			getTextures();
		}
		
		protected void Update()
		{

		}

		protected void OnGUI()
		{
			if(spellBarTexture == null || healthBarTexture == null || healthPatternTexture == null)
			{
				Debug.LogError("Assign a Texture in the inspector.");
				getTextures();
				return;
			}

			if(cam == null)
			{
				getCamera();
				return;
			}

			DisplaySpellBar();
			DisplayHealthBars();
		}

		private void getCamera()
		{
			GameObject camObj = GameObject.FindGameObjectWithTag("Camera");
			if(camObj != null)
				cam = (Camera)camObj.GetComponent(typeof(Camera));
		}

		private void getTextures()
		{
			healthBarTexture = (Texture)Resources.Load("GUI/health_bar");
			healthPatternTexture = (Texture)Resources.Load("GUI/health_pattern");
			spellBarTexture = (Texture)Resources.Load("GUI/spell_bar");
		}

		private void DisplaySpellBar()
		{
			Rect myRect = new Rect(Screen.width / 2 - spellBarTexture.width / 2, Screen.height - spellBarTexture.height, spellBarTexture.width, spellBarTexture.height);
			GUI.DrawTexture(myRect, spellBarTexture);
		}

		private void DisplayHealthBars()
		{
			float healthPatternMaxWidth = 103f;

			Component[] transformList = GameObject.Find("Pokemon").GetComponentsInChildren(typeof(Transform));

			foreach(Component comp in transformList) // We display the health bar at the feet position of the character.
			{
				Transform tr = comp.transform;
				PokemonController controller = (PokemonController)tr.gameObject.GetComponent(typeof(PokemonController));

				if(tr.parent != GameObject.Find("Pokemon").transform)
					continue;
				pos = cam.WorldToScreenPoint(tr.position + 3 * Vector3.up);
				Rect rectHealthBar = new Rect(pos.x - healthBarTexture.width / 2, Screen.height - pos.y, healthBarTexture.width, healthBarTexture.height);
				GUI.DrawTexture(rectHealthBar, healthBarTexture);

				Rect rectHealthPattern = new Rect();
				rectHealthPattern.x = rectHealthBar.x + 3;
				rectHealthPattern.y = rectHealthBar.y + 3;
				if(controller != null)
					rectHealthPattern.width = healthPatternMaxWidth * controller.currentHP / controller.maxHP;
				else
					rectHealthPattern.width = healthPatternMaxWidth;
				rectHealthPattern.height = healthPatternTexture.height;
				GUI.DrawTexture(rectHealthPattern, healthPatternTexture);

				/*rect.y += healthBarTexture.height;
				GUI.Label(rect, tr.gameObject.networkView.viewID.ToString());*/
			}
		}
	}
}