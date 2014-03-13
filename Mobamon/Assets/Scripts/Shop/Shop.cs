using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mobamon.Shop
{
    public class Shop : MonoBehaviour {

        public Texture backgroundTexture;
        private bool display = false;
        private List<ShopItem> items; 

    	// Use this for initialization
    	void Start () {
            items = new List<ShopItem>();
    	}
    	
    	// Update is called once per frame
    	void Update () {
            if (display && Input.GetKeyUp(KeyCode.Escape))
            {
                display = false;
            }
    	}

        private void DisplayBackground()
        {
            Rect myRect = new Rect(Screen.width / 2 - backgroundTexture.width / 2, Screen.height / 2 - backgroundTexture.height / 2, backgroundTexture.width, backgroundTexture.height);
            GUI.DrawTexture(myRect, backgroundTexture);
        }

        private void DisplayItems()
        {
            int count = 0;
            foreach (ShopItem item in items)
            {
                int backgroundLeft = (Screen.width - backgroundTexture.width) / 2;
                int backgroundTop = (Screen.height - backgroundTexture.height) / 2;


                Rect myRect = new Rect(backgroundLeft + 50, backgroundTop + 50 + (count * item.Picture.height), item.Picture.width, item.Picture.height); 
                GUI.DrawTexture(myRect, item.Picture);
                Rect myRect2 = new Rect(backgroundLeft + 60 + myRect.width, backgroundTop + 50 + (count * item.Picture.height), 200, item.Picture.height); 
                GUI.Label(myRect2, item.Name);
                Rect myRect3 = new Rect(backgroundLeft + 70 + myRect.width + myRect2.width, backgroundTop + 50 + (count * item.Picture.height), 50, item.Picture.height); 
                GUI.Label(myRect3, item.Price + "$");
                count += 1;
            }
        }

        void OnGUI() {
            if (display && !Network.isServer)
            {
                DisplayBackground();
                DisplayItems();
            }
        }

        void OnTriggerEnter (Collider collider) {
            display = true;
        }

        void OnTriggerExit (Collider collider) {
            display = false;
        }
    }
}