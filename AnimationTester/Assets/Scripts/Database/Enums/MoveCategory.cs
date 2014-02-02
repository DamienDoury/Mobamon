namespace Mobamon.Database.Enums
{
	/// <summary>
	/// The category of the move
	/// </summary>
	public enum MoveCategory
	{
		/// <summary>
		/// An invalid category for a move
		/// </summary>
		ERROR,

		/// <summary>
		/// The move is a physical attack
		/// </summary>
		Physical,

		/// <summary>
		/// The move is a special attack
		/// </summary>
		Special,

		/// <summary>
		/// The move is a status attack
		/// </summary>
		Status
	}
}

