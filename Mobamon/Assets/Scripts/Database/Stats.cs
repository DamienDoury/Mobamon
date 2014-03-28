namespace Mobamon.Database
{
	public class Stats
	{
		public int lvl { get; set; }
		
		public int xp { get; set; }

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
		
		public int hp { get; set; }
		public int attack { get; set; }
		public int defense { get; set; }
		public int specialAttack { get; set; }
		public int specialDefense { get; set; }
		public int speed { get; set; }

		public Stats()
		{
			lvl = 1;

			xp = 0;
			criticalChance = 16;
			precision = 1f;
			evasion = 1f;

			hp = 10;
			attack = 5;
			defense = 5;
			specialAttack = 5;
			specialDefense = 5;
			speed = 5;
		}
	}
}