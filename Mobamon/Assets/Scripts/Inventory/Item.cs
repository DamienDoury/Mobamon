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
        public IItemBehavior behavior;

        public Item()
        {
        }

        public Item(int id)
        {
            this.ID = id;
            this.Picture = (Texture)Resources.Load("Items/item_" + id);
        }

        public Item(int id, string identifier, string name, string description, int price, Texture2D picture, IItemBehavior behavior)
        {
            this.ID = id;
            this.Identifier = identifier;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Picture = picture;
            this.behavior = behavior;
        }

    }
}