using System;

namespace Mobamon.Evolution
{
    public class EvolutionLevelCondition : IEvolutionCondition
    {
        public int level;
        public int idBefore;
        public int idAfter;

        public EvolutionLevelCondition(int level, int idBefore, int idAfter)
        {
            this.level = level;
            this.idBefore = idBefore;
            this.idAfter = idAfter;
        }

        public void condition()
        {
            /*
            if (GameObject.FindWithTag("CameraTarget") != null)
            {
                GameObject pokemon = GameObject.FindWithTag("CameraTarget").gameObject;
            
                PokemonController controller = (PokemonController)pokemon.GetComponent<PokemonController>();
            }
            */
        }
    }
}

