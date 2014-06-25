using Mobamon.Database.Enums;

namespace Mobamon.Database.Classes
{
    public class PokemonInfo
    {
        public int Id { get; set; }
        public string ResourceName { get; set; }
        public string NameKey { get; set; }
		public LevelingRate LevelingSpeed { get; set; }
		public Stats Statistics { get; set; } 
    }
}

