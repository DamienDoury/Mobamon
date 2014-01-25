using UnityEngine;

public class Target
{
	public GameObject obj;
	public Vector3 pos;

	public Target(GameObject p_obj, Vector3 p_pos)
	{
		obj = p_obj;
		pos = p_pos;
	}
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