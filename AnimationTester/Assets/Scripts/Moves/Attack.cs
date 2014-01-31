using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Database;
using Mobamon.Database.Classes;
using Mobamon.Database.Enums;
using Mobamon.Pokemon.Player;

namespace Mobamon.Moves
{
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

		public bool hasAlreadyDamaged = false;
		public float duration = 0f;
		public float totalDuration;

		private bool isFinished = false;
		private List<Component> particleSystemList;
		
		void Start()
		{

		}

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

			if(Network.isServer)
			{
				duration += Time.deltaTime;

				if(info.isFollowing && duration > totalDuration * 0.3f && !hasAlreadyDamaged)
				{
					target.obj.networkView.RPC("SetDamage", RPCMode.AllBuffered, info.damage);
					hasAlreadyDamaged = true;
				}
			}

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
			totalDuration = 0f;
			if(isImmobilizing)
			{
				Transform mainParticleTransform = transform.Find("MainParticle");

				if(mainParticleTransform == null)
					Debug.LogError("The move " + moveName + " has no MainParticle child.");
				else
				{
					ParticleSystem mainParticle = (ParticleSystem)mainParticleTransform.gameObject.GetComponent(typeof(ParticleSystem));

					if(mainParticle == null)
						Debug.LogError("The MainParticle of the move " + moveName + " contains no ParticleSystem component.");
					else
					{
						totalDuration = mainParticle.duration;

						if(totalDuration > 2)
							Debug.LogError("The MainParticle of " + moveName + " lasts way too long and may cause animation issues.");
					}
				}

				/*foreach(ParticleSystem particleSystem in particleSystemList)
				{
					if(particleSystem.duration > totalDuration)
						totalDuration = particleSystem.duration;	
				}*/
			}

			return totalDuration;
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
}