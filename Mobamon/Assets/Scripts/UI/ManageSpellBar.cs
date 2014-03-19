using System;
using UnityEngine;
using Mobamon.Moves;
using Mobamon.Pokemon.Player;
using System.Collections.Generic;
using Mobamon.Pokemon.Classes;

namespace Mobamon.UI
{
    public class ManageSpellBar : MonoBehaviour
    {
        public Texture attackBarBorderTexture;
        public Texture attackBarForegroundTexture;
        public Dictionary<int, Vector2> movePosition;
        public List<SelectedMove> moveSet;

        public ManageSpellBar()
        {
        }

        public void initSpellBar()
        {
        }

        public void initMoves()
        {
            if (GameObject.FindWithTag("CameraTarget") != null)
            {
                GameObject pokemon = GameObject.FindWithTag("CameraTarget").gameObject;
                PokemonController controller = (PokemonController)pokemon.GetComponent<PokemonController>();
                moveSet.Clear();
                
                foreach (string move in controller.moveSet)
                {
                    moveSet.Add(new SelectedMove(move));
                    
                }
            }
        }

        public void displayMoves()
        {
            int count = 0;
            foreach (SelectedMove move in moveSet)
            {
                Rect myRect = new Rect (movePosition[count].x, movePosition[count].y, attackBarBorderTexture.width, attackBarBorderTexture.height);
                GUI.DrawTexture(myRect, attackBarBorderTexture);
                GUI.DrawTexture(myRect, attackBarForegroundTexture);
                GUIContent content = new GUIContent(move.name);
                GUIStyle style = new GUIStyle();

                style.padding = new RectOffset(10, 10, 0, 0);
                style.alignment = (count < 2 ?  TextAnchor.MiddleRight : TextAnchor.MiddleLeft);
                style.normal.textColor = Color.black;
                style.fontSize = 14;
                
                GUI.Label(myRect, content, style);
                count++;
            }
        }

        public void initPos()
        {
            movePosition = new Dictionary<int, Vector2>();
            movePosition.Add(0, new Vector2((Screen.width / 2) - attackBarBorderTexture.width - 80, Screen.height - attackBarBorderTexture.height - 55));
            movePosition.Add(1, new Vector2((Screen.width / 2) - attackBarBorderTexture.width - 40, Screen.height - attackBarBorderTexture.height - 80));
            movePosition.Add(2, new Vector2((Screen.width / 2) + 40, Screen.height - attackBarBorderTexture.height - 80));
            movePosition.Add(3, new Vector2((Screen.width / 2) + 80, Screen.height - attackBarBorderTexture.height - 55));
        }

        // Use this for initialization
        void Start () {
            moveSet = new List<SelectedMove>();
        }
        
        // Update is called once per frame
        void Update () {

        }
        
        void OnGUI() {

            if (!Network.isServer)
            {
                initPos();
                initMoves();   
                displayMoves();
            }
        }
    }
}

