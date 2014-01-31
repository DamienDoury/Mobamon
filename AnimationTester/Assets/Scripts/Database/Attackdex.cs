using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Attackdex
{
	public static readonly Dictionary<string, MoveInfo> move = new Dictionary<string, MoveInfo>
	{
		{
			"Waterfall",
			new MoveInfo()
			{
				damage = 60f,
				attackCategory = AttackCategory.Special,
				targetType = TargetType.Enemy,
				attackSource = AttackSource.Body,
				isImmobilizing = false,
				isFollowing = true,
				isProjectile = false
			}
		},
		{
			"Flamethrower",
			new MoveInfo()
			{
				damage = 90f,
				attackCategory = AttackCategory.Special,
				targetType = TargetType.Area,
				attackSource = AttackSource.Laser,
				isImmobilizing = true,
				isFollowing = false,
				isProjectile = false
			}
		},
		{
			"Growl",
			new MoveInfo()
			{
				damage = 0f,
				attackCategory = AttackCategory.Special,
				targetType = TargetType.Enemy,
				attackSource = AttackSource.Laser,
				isImmobilizing = false,
				isFollowing = true,
				isProjectile = false
			}
		},
		{
			"Thunder Shock",
			new MoveInfo()
			{
				damage = 120f,
				attackCategory = AttackCategory.Special,
				targetType = TargetType.Enemy,
				attackSource = AttackSource.Body,
				isImmobilizing = false,
				isFollowing = true,
				isProjectile = false
			}
		}
	};
}