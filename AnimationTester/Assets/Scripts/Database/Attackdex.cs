using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mobamon.Database.Classes;
using Mobamon.Database.Enums;

namespace Mobamon.Database
{
	public static class Attackdex
	{
		public static readonly Dictionary<string, MoveInfo> move = new Dictionary<string, MoveInfo>
		{
			{
				"Waterfall",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 60f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.OnHit,
					HittableTargetsNumber = MoveTargetNumber.One,
					IsFollowingTarget = true,
					IsImmobilizingCaster = false,
				    MovementSpeed = 0f,
					Radius = 1f,
					Shape = MoveShape.Point,
					Source = MoveSource.Body,
					TargetKind = MoveTargetKind.Single
				}
			},
			{
				"Flamethrower",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 90f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.PerSecond,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = false,
					IsImmobilizingCaster = true,
					MovementSpeed = 0f,
					Radius = 1f,
					Shape = MoveShape.Cone,
					Source = MoveSource.Laser,
					TargetKind = MoveTargetKind.Area
				}
			},
			{
				"Growl",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 0f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.OnHit,
					HittableTargetsNumber = MoveTargetNumber.One,
					IsFollowingTarget = false,
					IsImmobilizingCaster = false,
					MovementSpeed = 0f,
					Radius = 1f,
					Shape = MoveShape.Point,
					Source = MoveSource.Laser,
					TargetKind = MoveTargetKind.Single
				}
			},
			{
				"Thunder Shock",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 120f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.OnHit,
					HittableTargetsNumber = MoveTargetNumber.One,
					IsFollowingTarget = true,
					IsImmobilizingCaster = false,
					MovementSpeed = 0f,
					Radius = 1f,
					Shape = MoveShape.Point,
					Source = MoveSource.Body,
					TargetKind = MoveTargetKind.Single					
				}
			}
		};
	}
}