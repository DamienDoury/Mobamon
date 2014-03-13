using System;
using UnityEngine;

namespace Mobamon.Inventory
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Texture2D Picture { get; private set; }

        public InventoryItem()
        {
        }

        public InventoryItem(string name, int price, Texture2D picture)
        {
            this.Name = name;
            this.Price = price;
            this.Picture = picture;
        }
    }
}

