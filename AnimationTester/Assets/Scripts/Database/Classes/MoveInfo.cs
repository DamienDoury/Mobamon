using Mobamon.Database.Enums;

namespace Mobamon.Database.Classes
{
	/// <summary>
	/// Information on a move
	/// </summary>
	public struct MoveInfo
	{
		/// <summary>
		/// Gets or sets the allowed targets.
		/// </summary>
		/// <value>The allowed targets.</value>
		public PokemonRelation AllowedTargets { get; set; }

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public MoveCategory Category { get; set; }

		/// <summary>
		/// Gets or sets the damage.
		/// </summary>
		/// <value>The damage.</value>
		public float Damage { get; set; }
		
		/// <summary>
		/// Gets or sets the duration.
		/// </summary>
		/// <value>The duration.</value>
		public float Duration { get; set; }
		
		/// <summary>
		/// Gets or sets the percent of the move duration at which the effects should apply.
		/// WARNING : EffectType should be set to MoveEffectType.OnHit
		/// </summary>
		/// <value>The percent effect apply.</value>
		public float DurationPercentEffectsApply { get; set; }

		/// <summary>
		/// Gets or sets the type of the effect.
		/// </summary>
		/// <value>The type of the effect.</value>
		public MoveEffectType EffectType { get; set; }
		
		/// <summary>
		/// Gets or sets the simultaneous hittable targets.
		/// </summary>
		/// <value>The simultaneous hittable targets.</value>
		public MoveTargetNumber HittableTargetsNumber { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this move should follow the target.
		/// </summary>
		/// <value><c>true</c> if this move should follow target; otherwise, <c>false</c>.</value>
		public bool IsFollowingTarget { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this move should immobilize the caster while casting.
		/// </summary>
		/// <value><c>true</c> if this move should immobilize the caster; otherwise, <c>false</c>.</value>
		public bool IsImmobilizingCaster { get; set; }

		/// <summary>
		/// Gets or sets the movement speed.
		/// </summary>
		/// <value>The movement speed.</value>
		public float MovementSpeed { get; set; }

		/// <summary>
		/// Gets or sets the shape.
		/// </summary>
		/// <value>The shape.</value>
		public MoveShape Shape { get; set; }

		/// <summary>
		/// Gets or sets the source.
		/// </summary>
		/// <value>The source.</value>
		public MoveSource Source { get; set; }

		/// <summary>
		/// Gets or sets the kind of the target.
		/// </summary>
		/// <value>The kind of the target.</value>
		public MoveTargetKind TargetKind { get; set; }

		/// <summary>
		/// Gets or sets the radius
		/// </summary>
		/// <value>The radius.</value>
		public float Radius { get; set; }
	}
}

