using UnityEngine;
using System.Collections;

using Mobamon.Pokemon;

public class DamageInfo
{
	public float amount;
	public EntityManager caster;
	public float time;

	public DamageInfo(float _amount, EntityManager _caster)
	{
		amount = _amount;
		caster = _caster;
		time = Time.time;
	}
}
