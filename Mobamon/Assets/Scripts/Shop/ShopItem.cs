using System;
using UnityEngine;

namespace Mobamon.Shop
{
    public class ShopItem
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Texture2D Picture { get; private set; }

        public ShopItem()
        {
        }

        public ShopItem(string name, int price, Texture2D picture)
        {
            this.Name = name;
            this.Price = price;
            this.Picture = picture;
        }
    }
}

