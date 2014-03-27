using System;
using UnityEngine;
using Mobamon.Pokemon.Player;

namespace Mobamon.Inventory
{
    public class ItemHealthBehavior : IItemBehavior
    {
        public int hpRestored;

        public ItemHealthBehavior(int hpRestored)
        {
            this.hpRestored = hpRestored;
        }

        public void onClick()
        {
            if (GameObject.FindWithTag("CameraTarget") != null)
            {
                GameObject pokemon = GameObject.FindWithTag("CameraTarget").gameObject;
            
                PokemonController controller = (PokemonController)pokemon.GetComponent<PokemonController>();
                controller.entityManager.currentHP = (controller.entityManager.currentHP + hpRestored >= controller.entityManager.maxHP ? controller.entityManager.maxHP : controller.entityManager.currentHP + hpRestored);
            }



        }

        public void onUpdate()
        {

        }
    }
}

