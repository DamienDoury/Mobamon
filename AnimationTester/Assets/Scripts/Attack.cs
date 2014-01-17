using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attack : MonoBehaviour
{
	private string moveName;
	private Target source;
	private PokemonController sourceController;
	private Target target;
	private MoveInfo info;
	private bool isImmobilizing;
	private bool isFollowing;
	private bool isProjectile;

	private bool isFinished = false;
	private List<Component> particleSystemList;
	
	// Use this for initialization
	void Start()
	{
	
	}

	// Update is called once per frame
	void Update()
	{
		// We destroy the particles when they are one.
		List<int> particlesToRemove = new List<int>();
		int i = 0;
		bool allParticlesFinished = true;
		foreach(ParticleSystem particleSystem in particleSystemList)
		{
			if(!particleSystem.IsAlive())
			{
				particlesToRemove.Add(i);
				continue;
			}

			if(particleSystem.time < particleSystem.duration)
				allParticlesFinished = false;

			i++;
		}

		foreach(int index in particlesToRemove) // I separate this loop from the previous one otherwise it generates an error during runtime.
		{
			Destroy(particleSystemList[index].gameObject);
			particleSystemList.RemoveAt(index);
		}

		if(allParticlesFinished && !isFinished)
			isFinished = true;

		DisplaceFX(false);

		// If there is no more child particle the attack is done.
		if(transform.childCount == 0)
		{
			//sourceController.EndOfAttack();
			Destroy(gameObject);
		}
	}

	public float SetAttackParams(string p_moveName, Target p_source, Target p_target)
	{
		moveName = p_moveName;
		source = p_source;
		sourceController = (PokemonController)source.obj.GetComponent(typeof(PokemonController));
		target = p_target;

		info = Attackdex.move[moveName]; // The following parameters should be taken from the Attackdex.
		isImmobilizing = info.isImmobilizing;
		isFollowing = info.isFollowing;
		isProjectile = info.isProjectile;

		LaunchAttack();
		
		// If the move should not stop the attack animation, then we don't want to freeze it and we return 0.
		float longestDuration = 0f;
		if(isImmobilizing)
		{
			foreach(ParticleSystem particleSystem in particleSystemList)
			{
				if(particleSystem.duration > longestDuration)
					longestDuration = particleSystem.duration;	
			}
		}

		return longestDuration;
	}

	void LaunchAttack()
	{
		DisplaceFX(true);

		Component[] particleSystemListArray = GetComponentsInChildren(typeof(ParticleSystem));
		particleSystemList = new List<Component>(particleSystemListArray);
		foreach(ParticleSystem particle in particleSystemList)
		{
			particle.Play();
		}
	}

	void DisplaceFX(bool firstCall)
	{
		if(isProjectile)
		{

		}
		else
		{
			if(isImmobilizing)
			{
				// Ex: Flamethrower
				if(!isFinished)
				{
					transform.position = sourceController.laserSource.position;
					transform.forward = source.obj.transform.forward;
				}
			}
			else
			{
				if(target.obj)
				{
					if(info.attackSource == AttackSource.Laser)
					{
						// Ex: Growl
						if(firstCall)
						{
							transform.position = sourceController.laserSource.position;
							transform.forward = source.obj.transform.forward;
						}
					}
					else
					{
						// Ex: Waterfall
						transform.position = target.obj.transform.position;
						transform.forward = target.obj.transform.forward;
					}
				}
				else
				{
					// Ex: Rock Tomb
					transform.position = target.pos;
					if(firstCall)
						transform.forward = source.obj.transform.forward;
				}
			}
		}
	}
}
