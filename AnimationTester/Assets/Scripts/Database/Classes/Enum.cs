using UnityEngine;
using System.Collections;

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

public enum InputType
{
	ERROR,
	LeftClick,
	RightClick,
	Q,
	W,
	E,
	R
}