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
				attackCategory = AttackCategory.Special,
				targetType = TargetType.Enemy,
				attackSource = AttackSource.Laser,
				isImmobilizing = false,
				isFollowing = true,
				isProjectile = false
			}
		}
	};
}