using UnityEngine;
using System.Collections;

namespace Mobamon.Inventory {

    public class Item {

        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Texture Picture { get; private set; }
        public string Identifier { get; private set; }
        public string Description { get; private set; }
        public bool isUsable { get; private set; }
        public bool isConsumed { get; private set; }
        public IItemBehavior behavior;

        public Item()
        {
        }

        public Item(int id)
        {
            this.ID = id;
            this.Picture = (Texture)Resources.Load("Items/item_" + id);

            if (id == 165)
            {
                this.isUsable = true;
                this.isConsumed = true;
                this.behavior = new ItemHealthBehavior(50);
            }

        }

        public Item(int id, string identifier, string name, string description, int price, IItemBehavior behavior)
        {
            this.ID = id;
            this.Identifier = identifier;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Picture = (Texture)Resources.Load("Items/item_" + id);   
            this.behavior = behavior;
        }

        public Item(int id, string name, string identifier, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Identifier = identifier;
            this.Description = description;

            this.Price = 0;
            this.Picture = (Texture)Resources.Load("Items/item_" + id);           
            this.behavior = null;
        }
    }
}