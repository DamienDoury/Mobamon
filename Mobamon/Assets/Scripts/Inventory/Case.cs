using UnityEngine;
using System.Collections;

namespace Mobamon.Inventory {
    
    public class Case : MonoBehaviour {
        
        public Inventory inventory;
        public Texture caseNormalTexture;
        public Texture caseBerryTexture;
        public Texture caseSecureTexture;
        public Texture caseClosedTexture;
        public Item item { 
            get { return _item; } 
            set { 
                _item = value; 
                initItem();
            }
        } 
        private Item _item;
        public Vector2 casePos {
            get { return _casePos; }
            set {
                _casePos = value;
                initItem();
            }
        }
        private Vector2 _casePos;
        public Vector2 itemPos;
        public Vector2 itemInitialPos;
        public CaseType type;
        public bool isDragged = false;
        public bool isDisplayed = true;
        
        public Case()
        {
        }
        
        public void initCase(Vector2 casePos, CaseType type, Texture caseNormalTexture, Texture caseBerryTexture, Texture caseSecureTexture, Texture caseClosedTexture, Inventory inventory)
        {
            this.inventory = inventory;
            this.casePos = casePos;
            this.type = type;
            this.caseNormalTexture = caseNormalTexture;
            this.caseBerryTexture = caseBerryTexture;
            this.caseSecureTexture = caseSecureTexture;
            this.caseClosedTexture = caseClosedTexture;
        }
        
        public void initItem()
        {
            if (this.item != null)
            {
                this.itemPos.Set(casePos.x + (caseClosedTexture.width - item.Picture.width) / 2, casePos.y + (caseClosedTexture.height - item.Picture.height) / 2);
            }
        }
        
        private void DisplayBackground()
        {
            Rect myRect = new Rect(casePos.x, casePos.y, caseNormalTexture.width, caseNormalTexture.height);
            
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
        
        private void DisplayItem()
        {
            if (item != null)
            {
                Rect myRect = new Rect(itemPos.x, itemPos.y, item.Picture.width, item.Picture.height);
                GUI.DrawTexture(myRect, item.Picture);
            }
        }
        
        private void ManageMouse()
        {
            Rect itemPosRect = new Rect(itemPos.x, itemPos.y, caseNormalTexture.width, caseNormalTexture.height);
            Rect itemInitialPosRect = new Rect(itemInitialPos.x, itemInitialPos.y, caseNormalTexture.width, caseNormalTexture.height);
            
            if (Event.current.type == EventType.MouseDown && itemPosRect.Contains(Event.current.mousePosition) && isDisplayed)
            {
                if (this.item != null)
                {
                    this.isDragged = true;
                    this.itemInitialPos = this.itemPos;
                }
            }
            else if (Event.current.type == EventType.MouseDrag && this.isDragged)
            {
                this.itemPos.Set(Event.current.mousePosition.x - (caseNormalTexture.width / 2), Event.current.mousePosition.y - (caseNormalTexture.height / 2));
            }
            else if (Event.current.type == EventType.MouseUp)
            {
                if (this.isDragged)
                {
                    bool itemMoved = false;
                    foreach (Case currentCase in inventory.cases)
                    {
                        Rect currentRect = new Rect(currentCase.casePos.x, currentCase.casePos.y, currentCase.caseNormalTexture.width, currentCase.caseNormalTexture.height);
                        if (currentRect.Contains(Event.current.mousePosition) && currentCase.isDisplayed)
                        {
                            Item currentItem = this.item;
                            this.item = currentCase.item;
                            currentCase.item = currentItem;
                            itemMoved = true;
                            this.isDragged = false;
                        }
                    }
                    if (!itemMoved)
                    {
                        initItem();
                        this.isDragged = false;
                    }
                }
                
                if (this.item != null && this.item.isUsable && itemInitialPosRect.Contains(Event.current.mousePosition) && isDisplayed)
                {
                    this.item.behavior.onClick();
                    if (this.item.isConsumed)
                    {
                        this.item = null;
                    }
                }
                
                
            }
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
                ManageMouse();
                if (this.isDisplayed)
                {
                    DisplayBackground();
                    DisplayItem();
                }
            }
        }
    }
}