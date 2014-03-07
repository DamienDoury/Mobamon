namespace Mobamon.Database.Enums
{
	/// <summary>
	/// Indicates when the move effects should be applied
	/// </summary>
	public enum MoveEffectType
	{
		/// <summary>
		/// The effects are applied once on first hit
		/// </summary>
		OnHit,

		/// <summary>
		/// The effects are applied each time the target is hit
		/// </summary>
		PerSecond
	}
}

