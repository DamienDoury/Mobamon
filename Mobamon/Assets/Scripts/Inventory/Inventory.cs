using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mobamon.Pokemon;
using Mobamon.Pokemon.Player;
using Mobamon.Database;

namespace Mobamon.Inventory
{
    public class Inventory : MonoBehaviour {
        
        public Texture bagOpenTexture;
        public Texture bagClosedTexture;
        public Texture bagBackgroundTexture;
        public Texture bagReverseBackgroundTexture;
        public Texture caseNormalTexture;
        public Texture caseBerryTexture;
        public Texture caseSecureTexture;
        public Texture caseClosedTexture;
        public Vector2 bagPosition;
        public Vector2 bagBackgroundPosition;
        public bool isOpen; 
        public List<Case> cases; 
        public float lastScreenWidth = 0f;
        
        // Use this for initialization
        void Start () {

            isOpen = true;

            cases = new List<Case>();

            Vector2 casePosition = new Vector2(bagBackgroundPosition.x + bagBackgroundTexture.width + 5, Screen.height - caseNormalTexture.height - 5);

            for (int i = 0; i < 8; i++)
            {
                Case myCase = this.gameObject.AddComponent<Case>();
                myCase.initCase(casePosition, CaseType.Closed, caseNormalTexture, caseBerryTexture, caseSecureTexture, caseClosedTexture, this);
                myCase.item = ItemPool.item[240 + i * 5 - 1];
                cases.Add(myCase);
            }

            DisplayCases();

        }
        
        // Update is called once per frame
        void Update () {
     
        }
        
        private void DisplayBackground()
        {
            Rect myRect = new Rect(bagBackgroundPosition.x, bagBackgroundPosition.y, bagBackgroundTexture.width, bagBackgroundTexture.height);

            Texture texture = (isOpen ? bagReverseBackgroundTexture : bagBackgroundTexture);
            GUI.DrawTexture(myRect, texture);
        }

        private void DisplayBag()
        {
            Rect myRect = new Rect(bagPosition.x, bagPosition.y, bagOpenTexture.width, bagOpenTexture.height);

            Texture texture = (isOpen ? bagOpenTexture : bagClosedTexture);
            GUI.DrawTexture(myRect, texture);
        }

        private void ManageMouse()
        {
            Rect myRect = new Rect(bagBackgroundPosition.x, bagBackgroundPosition.y, bagBackgroundTexture.width, bagBackgroundTexture.height);
            if (Event.current.type == EventType.MouseUp && myRect.Contains(Event.current.mousePosition))
            {
                isOpen = !isOpen;
                DisplayCases();
            }
        }

        private void DisplayCases()
        {
            Vector2 casePosition = new Vector2(bagBackgroundPosition.x + bagBackgroundTexture.width + 5, Screen.height - caseNormalTexture.height - 5);

            foreach (Case myCase in cases)
            {
                if (isOpen || (myCase.item != null && myCase.item.isUsable))
                {
                    myCase.casePos = casePosition;
                    casePosition.Set(casePosition.x + caseNormalTexture.width + 2, casePosition.y);

                    myCase.isDisplayed = true;
                }
                else
                {
                    myCase.isDisplayed = false;
                }
            }

        }

        public void InitPos()
        {
            bagBackgroundPosition.Set(5, Screen.height - bagBackgroundTexture.height - 5);
            bagPosition.Set(bagBackgroundPosition.x + (bagBackgroundTexture.width - bagOpenTexture.width) / 2, bagBackgroundPosition.y + (bagBackgroundTexture.height - bagOpenTexture.height) / 2);
        }

        void OnGUI() {
            if (!Network.isServer)
            {
                InitPos();
                ManageMouse();
                DisplayBackground();
                DisplayBag();

                if (lastScreenWidth != Screen.width)
                {
                    lastScreenWidth = Screen.width;
                    DisplayCases();
                }
            }
        }

    }
}
