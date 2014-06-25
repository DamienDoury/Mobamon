using Mobamon.Database.Enums;

namespace Mobamon.Database
{
	public class Stats
	{
		public int lvl { get; set; }
		
		public int xp { get; set; }

		public LevelingRate levelingRate { get; set; }

		/// <summary>
		/// Represents the denominator of the fraction.
		/// </summary>
		/// <value>The critical chance.</value>
		public int criticalChance { get; set; }

		/// <summary>
		/// Represents a percentage.
		/// </summary>
		/// <value>The precision.</value>
		public float precision { get; set; }

		/// <summary>
		/// Represents a percentage.
		/// </summary>
		/// <value>The evasion.</value>
		public float evasion { get; set; }

		public int[] IV = new int[(int)StatsList.COUNT];
		public int[] EV = new int[(int)StatsList.COUNT];
		public int[] baseStats = new int[(int)StatsList.COUNT];
		public int[] currentStats = new int[(int)StatsList.COUNT];

		public Stats()
		{
			lvl = 1;

			xp = 0;
			levelingRate = LevelingRate.ERROR;
			criticalChance = 16;
			precision = 1f;
			evasion = 1f;

			for(int statID = 0; statID < (int)StatsList.COUNT; statID++)
			{
				IV[statID] = 0;
				EV[statID] = 0;
				baseStats[statID] = 5; // The minimum for a stat is 5, except for Shedinja's HP that goes down to 1.
				currentStats[statID] = 5;
			}
		}
	}
}