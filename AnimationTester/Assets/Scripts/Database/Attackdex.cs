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
					Shape = MoveShape.Point,
					Range = 650f,
					Source = MoveSource.TargetBody,
					TargetKind = MoveTargetKind.Single,
					AdditionalData = null
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
					Shape = MoveShape.Cone,
					Range = 780f,
					Source = MoveSource.Laser,
					TargetKind = MoveTargetKind.Area,
					AdditionalData = new ConeData()
					{
						HalfAngle = 5f
					}
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
					Shape = MoveShape.Point,
					Range = 1000f,
					Source = MoveSource.Laser,
					TargetKind = MoveTargetKind.Single,
					AdditionalData = null
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
					Shape = MoveShape.Point,
					Range = 500f,
					Source = MoveSource.TargetBody,
					TargetKind = MoveTargetKind.Single,
					AdditionalData = null
				}
			},
			{
				"Bubble",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 40f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.PerSecond,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = false,
					IsImmobilizingCaster = true,
					MovementSpeed = 0f,
					Shape = MoveShape.Cone,
					Range = 950f,
					Source = MoveSource.Laser,
					TargetKind = MoveTargetKind.Area,
					AdditionalData = new ConeData()
					{
						HalfAngle = 5f
					}
				}
			},
			{
				"Surf",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Self,
					Category = MoveCategory.Special,
					Damage = 90f,
					Duration = 0.75f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.OnHit,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = true,
					IsImmobilizingCaster = true,
					MovementSpeed = 0f,
					Shape = MoveShape.Sphere,
					Range = 1050f,
					Source = MoveSource.CasterBody,
					TargetKind = MoveTargetKind.Area,
					AdditionalData = null
				}
			},
			{
				"Scratch",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 40f,
					Duration = 0.2f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.OnHit,
					HittableTargetsNumber = MoveTargetNumber.One,
					IsFollowingTarget = true,
					IsImmobilizingCaster = false,
					MovementSpeed = 0f,
					Shape = MoveShape.Point,
					Range = 400f,
					Source = MoveSource.TargetBody,
					TargetKind = MoveTargetKind.Single,
					AdditionalData = null
				}
			},
			{
				"Razor Leaf",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 55f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.PerSecond,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = false,
					IsImmobilizingCaster = true,
					MovementSpeed = 0f,
					Shape = MoveShape.Cone,
					Range = 780f,
					Source = MoveSource.Laser,
					TargetKind = MoveTargetKind.Area,
					AdditionalData = new ConeData()
					{
						HalfAngle = 5f
					}
				}
			},
			{
				"Poison Gas",
				new MoveInfo()
				{
					AllowedTargets = PokemonRelation.Self,
					Category = MoveCategory.Special,
					Damage = 40f,
					Duration = 1f,
					DurationPercentEffectsApply = 0.3f,
					EffectType = MoveEffectType.OnHit,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = true,
					IsImmobilizingCaster = true,
					MovementSpeed = 0f,
					Shape = MoveShape.Sphere,
					Range = 1050f,
					Source = MoveSource.CasterBody,
					TargetKind = MoveTargetKind.Area,
					AdditionalData = null
				}
			}
		};
	}
}