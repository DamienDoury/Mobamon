using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mobamon.Inventory
{
    public class Inventory : MonoBehaviour {
        
        public Texture bagNormalTexture;
        public Texture bagBerryTexture;
        public Texture bagSecureTexture;
        public Texture caseNormalTexture;
        public Texture caseBerryTexture;
        public Texture caseSecureTexture;
        public Texture caseClosedTexture;
        public int totalNormalCases { get; set; }
        public int totalBerryCases { get; set; }
        public int totalSecureCases { get; set; }
        public int openNormalCases { get; set; }
        public int openBerryCases { get; set; }
        public int openSecureCases { get; set; }
        public int freeNormalCases { get; set; }
        public int freeBerryCases { get; set; }
        public int freeSecureCases { get; set; }


        private List<InventoryItem> items; 
        
        // Use this for initialization
        void Start () {
            totalNormalCases = 6;  
            totalBerryCases = 3;  
            totalSecureCases = 3;
            openNormalCases = 3;  
            openBerryCases = 1;  
            openSecureCases = 1;  
        }
        
        // Update is called once per frame
        void Update () {
     
        }
        
        private void DisplayBackground()
        {

        }

        private void DisplayCases()
        {

        }

        private void DisplayItems()
        {

        }
        
        void OnGUI() {
            if (!Network.isServer)
            {
                DisplayBackground();
                DisplayCases();
            }
        }

    }
}
