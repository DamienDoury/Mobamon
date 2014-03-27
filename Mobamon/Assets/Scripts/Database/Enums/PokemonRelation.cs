using System;

namespace Mobamon.Database.Enums
{
	/// <summary>
	/// Relation between two pokemons
	/// </summary>
	[Flags]
	public enum PokemonRelation
	{
		/// <summary>
		/// Either no Pokemon is targetted or an error occured
		/// </summary>
		ERROR = 0,

		/// <summary>
		/// The pokemons are the same
		/// </summary>
		Self = 1 << 0,

		/// <summary>
		/// The pokemons are allied
		/// </summary>
		Ally = 1 << 1,

		/// <summary>
		/// The pokemons are enemies
		/// </summary>
		Enemy = 1 << 2,
        
        /// <summary>
        /// The pokemons are neutral
        /// </summary>
        Neutral = 1 << 3
	}
}

