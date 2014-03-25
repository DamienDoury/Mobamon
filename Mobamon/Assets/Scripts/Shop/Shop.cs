using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mobamon.Inventory;

namespace Mobamon.Shop
{
    public class Shop : MonoBehaviour {

        public Texture backgroundTexture;
        private bool display = false;
        private List<Item> items; 

    	// Use this for initialization
    	void Start () {
            items = new List<Item>();
    	}
    	
    	// Update is called once per frame
    	void Update () {
            if (display && (Input.GetKeyUp(KeyCode.Escape) || Input.GetButtonUp("Shop")))
            {
                display = false;
            } 
            else if (!display && Input.GetButtonUp("Shop"))
            {
                display = true;
            }
    	}

        private void DisplayBackground()
        {
            Rect myRect = new Rect(Screen.width / 2 - backgroundTexture.width / 2, Screen.height / 2 - backgroundTexture.height / 2, backgroundTexture.width, backgroundTexture.height);
            GUI.DrawTexture(myRect, backgroundTexture);
        }

        private void DisplayItems()
        {

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