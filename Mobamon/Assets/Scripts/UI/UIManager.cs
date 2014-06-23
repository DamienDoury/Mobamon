using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mobamon.Pokemon;
using Mobamon.Pokemon.Player;
using Mobamon.Database;
using Mobamon.Database.Enums;

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
			else
			{
				DisplayHealthBars();
				DisplayPing();
				DisplayFPS();
			}
		}

		private void getCamera()
		{
			GameObject camObj = GameObject.FindGameObjectWithTag("MainCamera");
			if(camObj != null)
                cam = camObj.GetComponentInChildren<Camera>();
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
			Transform pokemonArray = SceneHelper.GetContainer(Container.Pokemons).transform;
			SortedList<int, Transform> pokemonSortedList = new SortedList<int, Transform>();

			/*
			 * We sort the Pokemons according to their distance to the eye so the life bar of the closest Pokemon appears
			 * in the foreground and overrides the ones of the farther Pokemons.
			 * The security offset is just here in case we find 2 Pokemons at the exact same distance. 
			 * In that case, it would add twice the same key in the SortedList and we don't want that.
			 */

			int securityOffset = 0;
			foreach(Transform tr in pokemonArray)
			{
				int dist = (int)(-1000f * Vector3.Distance(tr.position, cam.transform.position)) - ++securityOffset;
				pokemonSortedList.Add(dist, tr);
			}

			IList<Transform> pkmnList = pokemonSortedList.Values;

			int i = 0;
			foreach(Transform tr in pkmnList)
			{
				// Securities.
                if(tr.parent != SceneHelper.GetContainer(Container.Pokemons).transform)
					continue;

                if(!tr.GetComponentInChildren<SkinnedMeshRenderer>().enabled)
                    continue;

                EntityManager em = tr.GetComponent<EntityManager>();
				if(em == null)
					continue;

				// Z index management.
				GUI.depth = ++i;

				// We get the right health bar texture.
				if(em.team == 1)
					healthBarTexture = healthBar1Texture;
				else if(em.team == 2)
					healthBarTexture = healthBar2Texture;

				// We get the right health pattern texture.
                float HPpercentage = em.currentHP / em.maxHP;
				if(HPpercentage > 0.5)
					healthPatternTexture = healthPatternHighTexture;
				else if(HPpercentage > 0.2)
					healthPatternTexture = healthPatternMediumTexture;
				else
					healthPatternTexture = healthPatternLowTexture;

				// We display the health bar.
                pos = cam.WorldToScreenPoint(tr.position + 3 * cam.transform.up);
				Rect rectHealthBar = new Rect(pos.x - healthBarTexture.width / 2, Screen.height - pos.y, healthBarTexture.width, healthBarTexture.height);
				GUI.DrawTexture(rectHealthBar, healthBarTexture);

				// We display the amount of HP.
				Rect rectHealthPattern = new Rect();
                int displayOffset = 3 + (24 * (em.team % 2));
				rectHealthPattern.x = rectHealthBar.x + displayOffset;
				rectHealthPattern.y = rectHealthBar.y + 3;
                rectHealthPattern.width = healthPatternMaxWidth * em.currentHP / em.maxHP;
				rectHealthPattern.height = healthPatternTexture.height;
				GUI.DrawTexture(rectHealthPattern, healthPatternTexture);

                // We display the name (device name) of the player.
                rectHealthBar.y -= 20f;
                GUI.Label(rectHealthBar, SystemInfo.deviceName);

				// We display the level of the Pokemon.
				rectHealthBar.x += 114 - 108 * (em.team % 2);
				rectHealthBar.y += 23;
				GUI.Label(rectHealthBar, em.stats.lvl.ToString());
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