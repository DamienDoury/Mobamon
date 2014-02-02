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
		/// The pokemons are the same
		/// </summary>
		Self = 1,

		/// <summary>
		/// The pokemons are allied
		/// </summary>
		Ally = 2,

		/// <summary>
		/// The pokemons are enemies
		/// </summary>
		Enemy = 4
	}
}

