using System;
using UnityEngine;
using Mobamon.Pokemon.Player;
using System.Collections.Generic;

namespace Mobamob.Towers
{
    public class Tower : MonoBehaviour
    {
        public int teamId;
        public float maxHP = 300f;
        public float currentHP = 300f;
        public float range = 10f;
        public float cooldown = 3f;
        public int lastAttack;
        public Vector3 position;

        public List<PokemonController> availableTarget;
        public PokemonController currentTarget;
        public PokemonController lastTarget;

        public Tower()
        {
        }

        public Tower(int teamId)
        {
            this.teamId = teamId;
            this.position = this.transform.position;
            this.availableTarget = new List<PokemonController>();
        }

        public void DisplayRange()
        {
        }

        public void GetAvailableTargets()
        {
            Component[] transformList = GameObject.Find("Pokemon").GetComponentsInChildren(typeof(Transform));
            this.availableTarget.Clear();

            foreach (Component comp in transformList)
            {
                Transform tr = comp.transform;
                if (tr.parent != GameObject.Find("Pokemon").transform)
                    continue;
                
                PokemonController controller = (PokemonController)tr.gameObject.GetComponent(typeof(PokemonController));
                if (controller == null)
                    continue;

                float distance = Vector3.Distance(this.position, tr.position);
                if (distance - controller.nav.radius < this.range)
                {
                    this.availableTarget.Add(controller);
                }
            }
        }

        public void GetTarget()
        {
            GetAvailableTargets();

            foreach (PokemonController pokemon in availableTarget)
            {
                if (lastTarget != null && availableTarget.Contains(lastTarget))
                {
                    currentTarget = lastTarget;
                }
                else
                {
                    currentTarget = pokemon;
                }
            }

            Console.Write("Target");
        }

        public void LaunchAttack()
        {

        }

        void Start()
        {
            this.position = this.transform.position;
            this.availableTarget = new List<PokemonController>();
        }

        void Update()
        {
        }

        void OnGUI()
        {
            GetTarget();
        }
    }
}

