using UnityEngine;
using System.Collections;

namespace Mobamon.Inventory {

    public class Case : MonoBehaviour {

        public Texture caseNormalTexture;
        public Texture caseBerryTexture;
        public Texture caseSecureTexture;
        public Texture caseClosedTexture;
        public Item item;
        public Vector2 pos;
        public CaseType type;

        public Case()
        {
        }

        public void initCase(Vector2 pos, CaseType type, Texture caseNormalTexture, Texture caseBerryTexture, Texture caseSecureTexture, Texture caseClosedTexture)
        {
            this.pos = pos;
            this.type = type;
            this.caseNormalTexture = caseNormalTexture;
            this.caseBerryTexture = caseBerryTexture;
            this.caseSecureTexture = caseSecureTexture;
            this.caseClosedTexture = caseClosedTexture;
        }

        public void DisplayBackground()
        {
            Rect myRect = new Rect(pos.x, pos.y, caseNormalTexture.width, caseNormalTexture.height);

            Texture texture = new Texture();
            switch (type)
            {
                case CaseType.Closed:
                    texture = caseClosedTexture;
                    break;
                case CaseType.Berry:
                    texture = caseBerryTexture;
                    break;
                case CaseType.Normal:
                    texture = caseNormalTexture;
                    break;
                case CaseType.Secure:
                    texture = caseSecureTexture;
                    break;
            }

            GUI.DrawTexture(myRect, texture);
        }

        public void DisplayItem()
        {
            Rect myRect = new Rect(pos.x + (caseClosedTexture.width - item.Picture.width) / 2, pos.y + (caseClosedTexture.height - item.Picture.height) / 2, item.Picture.width, item.Picture.height);
            GUI.DrawTexture(myRect, item.Picture);
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
                DisplayBackground();
                DisplayItem();
            }
        }
    }
}