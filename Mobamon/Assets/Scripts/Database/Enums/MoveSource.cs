namespace Mobamon.Database.Enums
{
	/// <summary>
	/// The source of the move
	/// </summary>
	public enum MoveSource
	{
		/// <summary>
		/// An invalid source of move
		/// </summary>
		ERROR,
		
		/// <summary>
		/// The move comes from the laser bone
		/// </summary>
		Laser,
		
		/// <summary>
		/// The move comes from the entire body of the caster
		/// </summary>
		CasterBody,
		
		/// <summary>
		/// The move comes from the entire body of the target
		/// </summary>
		TargetBody,
		
		/// <summary>
		/// The move comes from the cast area
		/// </summary>
		Area
	}
}

