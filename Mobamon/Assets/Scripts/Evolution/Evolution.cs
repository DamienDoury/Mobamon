using System;
using UnityEngine;

namespace Mobamon.Evolution
{
    public class Evolution : MonoBehaviour
    {
        public int idBefore;
        public int idAfter;
        public IEvolutionCondition condition;

        public Evolution(int idBefore, int idAfter)
        {
            this.idBefore = idBefore;
            this.idAfter = idAfter;

            this.condition = new EvolutionLevelCondition(10, idBefore, idAfter);
        }

        public void Start()
        {
        }

        public void Update()
        {
        }

        public void OnGUI()
        {
        }
    }
}

