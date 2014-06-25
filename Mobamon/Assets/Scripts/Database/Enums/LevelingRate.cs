namespace Mobamon.Database.Enums
{
	/// <summary>
	/// XP curves
	/// "the amount [of experience] varies depending on species, always remaining consistent throughout an evolutionary family, 
	/// a given amount of experience points will always set a Pokémon at the corresponding level"
	/// http://bulbapedia.bulbagarden.net/wiki/Experience
	/// </summary>
	public enum LevelingRate
	{
		/// <summary>
		/// XP to lvl 100 = 600k
		/// Piecewise functions
		/// Slow at low level and fast at high levels
		/// </summary>
		Erratic,

		/// <summary>
		/// XP to lvl 100 = 600k
		/// Polynomial function
		/// Fast overall
		/// </summary>
		Fast,

		/// <summary>
		/// XP to lvl 100 = 800k
		/// Piecewise functions
		/// Quite fast overall
		/// </summary>
		MediumFast,

		/// <summary>
		/// XP to lvl 100 = 1 000k
		/// Polynomial function
		/// Quite slow overall
		/// </summary>
		MediumSlow,

		/// <summary>
		/// XP to lvl 100 = 1 059,86k
		/// Polynomial function
		/// Slow overall
		/// </summary>
		Slow,

		/// <summary>
		/// XP to lvl 100 = 1 640k
		/// Piecewise functions
		/// Fast at low level and slow at high levels
		/// </summary>
		Fluctuating,

		COUNT,
		ERROR
	}
}

