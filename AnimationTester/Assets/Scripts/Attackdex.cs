using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum AttackCategory
{
	ERROR,
	Physical,
	Special,
	Status
}

public enum TargetType
{
	ERROR,
	Enemy,
	Area,
	Self,
	Ally
}

public enum AttackSource
{
	ERROR,
	Laser,
	Body
}

public struct MoveInfo
{
	public AttackCategory attackCategory;
	public TargetType targetType;
	public AttackSource attackSource;

	public bool isImmobilizing;
	public bool isFollowing;
	public bool isProjectile;
}

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