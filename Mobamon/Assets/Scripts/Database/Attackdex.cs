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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 60f,
					Duration = 1f,
					EffectType = MoveEffectType.OnHit,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 90f,
					Duration = 1f,
					EffectType = MoveEffectType.PerSecond,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 0f,
					Duration = 1f,
					EffectType = MoveEffectType.OnHit,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 120f,
					Duration = 1f,
					EffectType = MoveEffectType.OnHit,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 40f,
					Duration = 1f,
					EffectType = MoveEffectType.PerSecond,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					AllowedTargets = PokemonRelation.Enemy,
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 90f,
					Duration = 0.75f,
					EffectType = MoveEffectType.OnHit,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Physical,
					Damage = 40f,
					Duration = 0.2f,
					EffectType = MoveEffectType.OnHit,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
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
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Physical,
					Damage = 55f,
					Duration = 1f,
					EffectType = MoveEffectType.PerSecond,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = false,
					IsImmobilizingCaster = false,
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
					AllowedTargets = PokemonRelation.Enemy,
					DamageTargets = PokemonRelation.Enemy,
					Category = MoveCategory.Special,
					Damage = 40f,
					Duration = 0.75f,
					EffectType = MoveEffectType.OnHit,
					DurationPercentEffectsApply = 0.3f,
					DelayBeforeDamage = 0.2f,
					HittableTargetsNumber = MoveTargetNumber.Multiple,
					IsFollowingTarget = false,
					IsImmobilizingCaster = false,
					MovementSpeed = 0f,
					Shape = MoveShape.Sphere,
					Range = 1050f,
					Source = MoveSource.CasterBody,
					TargetKind = MoveTargetKind.Area,
					AdditionalData = null
				}
			},
            {
                "Venoshock",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 65f,
                    Duration = 0.5f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.2f,
                    HittableTargetsNumber = MoveTargetNumber.One,
                    IsFollowingTarget = true,
                    IsImmobilizingCaster = false,
                    MovementSpeed = 0f,
                    Shape = MoveShape.Point,
                    Range = 600f,
                    Source = MoveSource.TargetBody,
                    TargetKind = MoveTargetKind.Single,
                    AdditionalData = null
                }
            },
            {
                "Icicle Crash",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Physical,
                    Damage = 85f,
                    Duration = 0.5f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.2f,
                    HittableTargetsNumber = MoveTargetNumber.One,
                    IsFollowingTarget = true,
                    IsImmobilizingCaster = false,
                    MovementSpeed = 0f,
                    Shape = MoveShape.Point,
                    Range = 600f,
                    Source = MoveSource.TargetBody,
                    TargetKind = MoveTargetKind.Single,
                    AdditionalData = null
                }
            },
            {
                "Leer",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 0f,
                    Duration = 0.75f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.3f,
                    HittableTargetsNumber = MoveTargetNumber.One,
                    IsFollowingTarget = true,
                    IsImmobilizingCaster = true,
                    MovementSpeed = 0f,
                    Shape = MoveShape.Point,
                    Range = 600f,
                    Source = MoveSource.CasterBody,
                    TargetKind = MoveTargetKind.Single,
                    AdditionalData = null
                }
            },
            {
                "Supersonic",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 0f,
                    Duration = 1f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.3f,
                    HittableTargetsNumber = MoveTargetNumber.One,
                    IsFollowingTarget = true,
                    IsImmobilizingCaster = true,
                    MovementSpeed = 0f,
                    Shape = MoveShape.Point,
                    Range = 700f,
                    Source = MoveSource.Laser,
                    TargetKind = MoveTargetKind.Single,
                    AdditionalData = null
                }
            },
            {
                "Mud Sport",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 0f,
                    Duration = 0.5f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.2f,
                    HittableTargetsNumber = MoveTargetNumber.Multiple,
                    IsFollowingTarget = false,
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
                "Poison Sting",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 0f,
                    Duration = 0.5f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.2f,
                    HittableTargetsNumber = MoveTargetNumber.Multiple,
                    IsFollowingTarget = false,
                    IsImmobilizingCaster = false,
                    MovementSpeed = 0f,
                    Shape = MoveShape.Sphere,
                    Range = 800f,
                    Source = MoveSource.Area,
                    TargetKind = MoveTargetKind.Area,
                    AdditionalData = null
                }
            },
            {
                "Gust",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 40f,
                    Duration = 0.5f,
                    EffectType = MoveEffectType.OnHit,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.2f,
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
                "Move test",
                new MoveInfo()
                {
                    AllowedTargets = PokemonRelation.Enemy,
                    DamageTargets = PokemonRelation.Enemy,
                    Category = MoveCategory.Special,
                    Damage = 0f,
                    Duration = 1f,
                    EffectType = MoveEffectType.PerSecond,
                    DurationPercentEffectsApply = 0.3f,
                    DelayBeforeDamage = 0.2f,
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
            }
		};
	}
}