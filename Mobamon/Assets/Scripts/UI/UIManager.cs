using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Pokemon.Player;

namespace Mobamon.UI
{
	public class UIManager : MonoBehaviour
	{
		public Texture spellBarTexture;
		public Texture healthBarTexture;
		public Texture healthBar1Texture;
		public Texture healthBar2Texture;
		public Texture healthPatternLowTexture;
		public Texture healthPatternMediumTexture;
		public Texture healthPatternHighTexture;
		private float healthPatternMaxWidth = 104f;

		private List<float> FPSList = new List<float>();
		private float LastFPSUpdate = 0f;
		private float FPSRefreshRate = 1f;
		private float LastFPSValue = 0f;
        private Camera cam = null;
        private Texture healthPatternTexture;
		public Vector3 pos;

		protected void Start()
		{
			//getTextures();
		}
		
		protected void Update()
		{
			LastFPSUpdate += Time.fixedDeltaTime;
			
			if(LastFPSUpdate < FPSRefreshRate)
			{
				FPSList.Add(Time.timeScale / Time.deltaTime);
			}
			else
			{
				float count = 0f;
				foreach(float deltaFrame in FPSList)
					count += deltaFrame;
				
				LastFPSValue = count / FPSList.Count;
				
				FPSList.Clear();
				LastFPSUpdate = 0f;
			}
		}

		protected void OnGUI()
		{
			if(spellBarTexture == null || 
			   healthBar1Texture == null || 
			   healthBar2Texture == null || 
			   healthPatternLowTexture == null ||
			   healthPatternMediumTexture == null ||
			   healthPatternHighTexture == null)
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

			DisplayHealthBars();
			DisplayPing();
			DisplayFPS();
		}

		private void getCamera()
		{
			GameObject camObj = GameObject.FindGameObjectWithTag("MainCamera");
			if(camObj != null)
				cam = (Camera)camObj.GetComponent(typeof(Camera));
		}

		private void getTextures()
		{
			healthBar1Texture = (Texture)Resources.Load("GUI/health_bar_1");
			healthBar2Texture = (Texture)Resources.Load("GUI/health_bar_2");

			healthPatternLowTexture = (Texture)Resources.Load("GUI/low_health_pattern");
			healthPatternMediumTexture = (Texture)Resources.Load("GUI/medium_health_pattern");
			healthPatternHighTexture = (Texture)Resources.Load("GUI/high_health_pattern");

			spellBarTexture = (Texture)Resources.Load("GUI/spell_bar");
		}

		private void DisplayHealthBars()
		{
			Component[] transformList = GameObject.Find("Pokemon").GetComponentsInChildren(typeof(Transform));

			foreach(Component comp in transformList)
			{
				// Securities.
				Transform tr = comp.transform;
				if(tr.parent != GameObject.Find("Pokemon").transform)
					continue;

				PokemonController controller = (PokemonController)tr.gameObject.GetComponent(typeof(PokemonController));
				if(controller == null)
					continue;

				// We get the right health bar texture.
				if(controller.team == 1)
					healthBarTexture = healthBar1Texture;
				else if(controller.team == 2)
					healthBarTexture = healthBar2Texture;

				// We get the right health pattern texture.
				float HPpercentage = controller.currentHP / controller.maxHP;
				if(HPpercentage > 0.5)
					healthPatternTexture = healthPatternHighTexture;
				else if(HPpercentage > 0.2)
					healthPatternTexture = healthPatternMediumTexture;
				else
					healthPatternTexture = healthPatternLowTexture;

				// We display the health bar.
				pos = cam.WorldToScreenPoint(tr.position + 3 * Vector3.up + 2 * Vector3.forward);
				Rect rectHealthBar = new Rect(pos.x - healthBarTexture.width / 2, Screen.height - pos.y, healthBarTexture.width, healthBarTexture.height);
				GUI.DrawTexture(rectHealthBar, healthBarTexture);

				// We display the amount of HP.
				Rect rectHealthPattern = new Rect();
				int displayOffset = 3 + (24 * (controller.team % 2));
				rectHealthPattern.x = rectHealthBar.x + displayOffset;
				rectHealthPattern.y = rectHealthBar.y + 3;
				rectHealthPattern.width = healthPatternMaxWidth * controller.currentHP / controller.maxHP;
				rectHealthPattern.height = healthPatternTexture.height;
				GUI.DrawTexture(rectHealthPattern, healthPatternTexture);
			}
		}

		private void DisplayPing()
		{
			if(!Network.isServer)
			{
				string ping = "?";

				if(Network.connections.Length > 0)
					ping = Network.GetAveragePing(Network.connections[0]).ToString();

				GUI.Label(new Rect(0, 0, 80, 30), "Ping:" + ping + "ms");
			}
		}

		private void DisplayFPS()
		{
			GUI.Label(new Rect(0, 20, 80, 30), "FPS:" + (int)LastFPSValue);
		}
	}
}