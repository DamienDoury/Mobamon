using System;
using UnityEngine;
using Mobamon.Pokemon.Player;
using System.Collections.Generic;
using Mobamon.Pokemon.Classes;
using Mobamon.Database;
using Mobamon.Database.Enums;

namespace Mobamon.UI
{
    public class ManageTeamBar : MonoBehaviour
    {
        public Texture healthPatternEmptyTexture;
        public Texture healthPatternLowTexture;
        public Texture healthPatternMediumTexture;
        public Texture healthPatternHighTexture;
        public Vector2 posTeam1;
        public Vector2 posTeam2;

        public ManageTeamBar()
        {
        }

        // Use this for initialization
        void Start () {

        }
        
        // Update is called once per frame
        void Update () {
            
        }

        public void DisplayHealth() {
            Transform[] transformList = SceneHelper.GetContainer(Container.Pokemons).GetComponentsInChildren<Transform>();
            Texture healthPatternTexture;
            posTeam1.Set(50, 0);
            posTeam2.Set(Screen.width - 96 - 50, 0);
            Vector2 pos = new Vector2(0, 0);
            Texture texture = new Texture();

            foreach (Transform tr in transformList)
            {
                if (tr.parent != SceneHelper.GetContainer(Container.Pokemons).transform)
                    continue;
                
                PokemonController controller = (PokemonController)tr.gameObject.GetComponent(typeof(PokemonController));
                if (controller == null)
                    continue;

                if (controller.team == 1)
                {
                    texture = (Texture)Resources.Load("Portraits/Mirror/pokemon_mirror_" + controller.id);
                    pos = posTeam1;
                    posTeam1.Set(posTeam1.x + texture.width + 1, posTeam1.y);
                }
                else if (controller.team == 2)
                {
                    texture = (Texture)Resources.Load("Portraits/Front/pokemon_front_" + controller.id);
                    pos = posTeam2;
                    posTeam2.Set(posTeam2.x - texture.width - 1, posTeam2.y);
                }
                
                float HPpercentage = controller.currentHP / controller.maxHP;
                if (HPpercentage > 0.5)
                    healthPatternTexture = healthPatternHighTexture;
                else if (HPpercentage > 0.2)
                    healthPatternTexture = healthPatternMediumTexture;
                else
                    healthPatternTexture = healthPatternLowTexture;
                
                Rect rectHealthBar = new Rect(pos.x, pos.y, texture.width, healthPatternEmptyTexture.height);
                GUI.DrawTexture(rectHealthBar, healthPatternEmptyTexture);
                
                Rect rectHealthPattern = new Rect(pos.x, pos.y, texture.width * controller.currentHP / controller.maxHP, healthPatternTexture.height);
                GUI.DrawTexture(rectHealthPattern, healthPatternTexture);

                Rect rectPortrait = new Rect(pos.x, pos.y + healthPatternEmptyTexture.height, texture.width, texture.height);
                GUI.DrawTexture(rectPortrait, texture);
            }
        }
        
        void OnGUI() {
            DisplayHealth();
        }
    }
}

