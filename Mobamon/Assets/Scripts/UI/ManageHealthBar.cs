using System;
using UnityEngine;
using Mobamon.Pokemon;
using Mobamon.Pokemon.Player;

namespace Mobamon.UI
{
    public class ManageHealthBar : MonoBehaviour
    {

        public Texture backgroundTopTexture;
        public Texture backgroundBottomTexture;
        public Texture centerTexture;
        public Texture centerBorderTexture;
        public Texture frontTopTexture;
        public Texture frontBottomTexture;
        public Vector2 pos;
        public Vector2 pivot;
        public float angle;

        public ManageHealthBar()
        {
        }


        public void DisplayBackground()
        {
            Rect myRect = new Rect(pos.x, pos.y, centerTexture.width, centerTexture.height);
            GUI.DrawTexture(myRect, backgroundBottomTexture);
            GUI.DrawTexture(myRect, backgroundTopTexture);
           
        }

        public void DisplayForeground()
        {
            Rect myRect = new Rect(pos.x, pos.y, centerTexture.width, centerTexture.height);
            GUI.DrawTexture(myRect, centerBorderTexture);
            GUI.DrawTexture(myRect, centerTexture);
        }

        public void DisplayHealth()
        {

            
            Rect myRect = new Rect(pos.x, pos.y, centerTexture.width, centerTexture.height);

            if (GameObject.FindWithTag("CameraTarget") != null)
            {
                GameObject pokemon = GameObject.FindWithTag("CameraTarget").gameObject;
                EntityManager em = pokemon.GetComponent<EntityManager>();

                pivot.Set(Screen.width / 2, Screen.height - (centerTexture.height / 2) - 5);
                angle = ((em.maxHP - em.currentHP) * 100 / em.maxHP) * -1.8f;
            }


            Matrix4x4 matrixBackup = GUI.matrix;
            GUIUtility.RotateAroundPivot(angle, pivot);
            GUI.DrawTexture(myRect, frontTopTexture);
            GUI.matrix = matrixBackup;
        }

        public void DisplayXP()
        {
            Rect myRect = new Rect(pos.x, pos.y, centerTexture.width, centerTexture.height);
            //GUIUtility.RotateAroundPivot(-angle, pivot);
            GUI.DrawTexture(myRect, frontBottomTexture);
        }

        public void InitPos()
        {
            pos.Set((Screen.width - centerTexture.width) / 2, (Screen.height - centerTexture.height) - 5);
            angle = 0;
        }

        // Use this for initialization
        void Start () {

        }
        
        // Update is called once per frame
        void Update () {
            
        }
        
        void OnGUI() {
            if (!Network.isServer)
            {
                InitPos();
                DisplayBackground();
                DisplayHealth();
                DisplayXP();
                DisplayForeground();
            }
        }
    }
}

