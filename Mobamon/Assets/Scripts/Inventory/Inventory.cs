using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mobamon.Inventory
{
    public class Inventory : MonoBehaviour {
        
        public Texture bagOpenTexture;
        public Texture bagClosedTexture;
        public Texture bagBackgroundTexture;
        public Texture caseNormalTexture;
        public Texture caseBerryTexture;
        public Texture caseSecureTexture;
        public Texture caseClosedTexture;
        public Vector2 bagPosition;
        public Vector2 bagBackgroundPosition;
        private bool isOpen = false; 

        private List<Case> cases; 
        
        // Use this for initialization
        void Start () {
            cases = new List<Case>();

            bagBackgroundPosition.Set(5, Screen.height - bagBackgroundTexture.height - 5);
            bagPosition.Set(bagBackgroundPosition.x + (bagBackgroundTexture.width - bagOpenTexture.width) / 2, bagBackgroundPosition.y + (bagBackgroundTexture.height - bagOpenTexture.height) / 2);
        
            Vector2 casePosition = new Vector2(bagBackgroundPosition.x + bagBackgroundTexture.width + 5, Screen.height - caseNormalTexture.height - 5);

            for (int i = 0; i < 8; i++)
            {
                Case myCase = this.gameObject.AddComponent<Case>();
                myCase.initCase(casePosition, CaseType.Closed, caseNormalTexture, caseBerryTexture, caseSecureTexture, caseClosedTexture);
                myCase.item = new Item(i + 1);
                cases.Add(myCase);
                casePosition.Set(casePosition.x + caseNormalTexture.width + 2, casePosition.y);
            }
        }
        
        // Update is called once per frame
        void Update () {
     
        }
        
        private void DisplayBackground()
        {
            Rect myRect = new Rect(bagBackgroundPosition.x, bagBackgroundPosition.y, bagBackgroundTexture.width, bagBackgroundTexture.height);
            GUI.DrawTexture(myRect, bagBackgroundTexture);
        }

        private void DisplayBag()
        {
            Rect myRect = new Rect(bagPosition.x, bagPosition.y, bagOpenTexture.width, bagOpenTexture.height);

            Texture texture = (isOpen ? bagOpenTexture : bagClosedTexture);
            GUI.DrawTexture(myRect, texture);
        }

        void OnGUI() {
            if (!Network.isServer)
            {
                DisplayBackground();
                DisplayBag();
            }
        }

    }
}
