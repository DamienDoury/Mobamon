using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Mobamon.Database;
using Mobamon.Database.Classes;
using Mobamon.Database.Enums;
using Mobamon.Pokemon.Player;

namespace Mobamon.Moves
{
	public class Move : MonoBehaviour
	{
		#region Properties

		/// <summary>
		/// Gets or sets the current duration.
		/// </summary>
		/// <value>The current duration.</value>
		private float CurrentDuration { get; set; }

		/// <summary>
		/// Gets or sets the current duration since the animation has stopped.
		/// </summary>
		/// <value>The duration of the current stop.</value>
		private float CurrentStopDuration { get; set; }

		/// <summary>
		/// Gets or sets the enemies hit.
		/// </summary>
		/// <value>The enemies hit.</value>
		private List<Collider> EnemiesHit { get; set; }

		/// <summary>
		/// Gets or sets the enemies to hit for the current frame.
		/// </summary>
		/// <value>The enemies to hit.</value>
		private List<Collider> EnemiesToHit { get; set; }

		/// <summary>
		/// Gets the move info.
		/// </summary>
		/// <value>The move info.</value>
		private MoveInfo Info { get; set; }

		/// <summary>
		/// Gets the source.
		/// </summary>
		/// <value>The source.</value>
		private MoveTarget Source { get; set;}

		/// <summary>
		/// Gets the target.
		/// </summary>
		/// <value>The target.</value>
		private MoveTarget Target { get; set; }

		/// <summary>
		/// Gets or sets the particle systems.
		/// </summary>
		/// <value>The particle systems.</value>
		private List<ParticleSystem> ParticleSystems { get; set; }

		/// <summary>
		/// Gets or sets the main particle system.
		/// </summary>
		/// <value>The main particle system.</value>
		private ParticleSystem MainParticleSystem { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is running.
		/// </summary>
		/// <value><c>true</c> if this instance is running; otherwise, <c>false</c>.</value>
		private bool IsRunning { get; set; }

		private GameObject ColliderObject { get; set; }

		#endregion

		#region Public methods

		/// <summary>
		/// Start this instance.
		/// </summary>
		public void Start()
		{
			this.EnemiesHit = new List<Collider>();
			this.EnemiesToHit = new List<Collider>();
		}

		/// <summary>
		/// Update this instance.
		/// </summary>
		public void Update()
		{
			if (this.IsRunning)
			{
				this.CurrentDuration = this.CurrentDuration + Time.deltaTime;

				if (this.MainParticleSystem != null && this.CurrentDuration > this.MainParticleSystem.duration)
				{
					this.CurrentStopDuration = this.CurrentStopDuration + Time.deltaTime;
				}

				this.HandleMovement();

				if (this.EnemiesToHit.Count > 0)
				{
					this.HandleCollision();
				}

				this.HandleFX();
			}
		}

		/// <summary>
		/// When the move collider is triggered, stores the other collider to check for damage on next update
		/// </summary>
		/// <param name="otherCollider">Other collider.</param>
		public void RegisterCollider(Collider otherCollider)
		{
			if (Network.isServer && this.EnemiesToHit != null && !this.EnemiesToHit.Contains(otherCollider))
			{
				this.EnemiesToHit.Add(otherCollider);
			}
		}

		/// <summary>
		/// Sets the move parameters.
		/// </summary>
		/// <param name="moveName">Move name.</param>
		/// <param name="source">Source.</param>
		/// <param name="target">Target.</param>
		public float SetMoveParameters(string moveName, MoveTarget source, MoveTarget target)
		{
			float animationFreezeDuration = 0f;

			if (!Attackdex.move.ContainsKey(moveName))
			{
				Debug.LogError("The move '" + moveName + "' is not registered in Attackdex");
			}
			else
			{
				this.Info = Attackdex.move[moveName];
				Vector3 startPosition = source.StartPosition;
				Vector3 forward = source.GameObject.transform.forward;

				Collider collider = this.GetComponentInChildren<Collider>();
				this.ColliderObject = collider.gameObject;

				this.IsRunning = true;
				this.Source = source;
				this.Target = target;

				startPosition = this.GetPosition();

				// Move the collider to the right place
				this.ColliderObject.transform.position = startPosition;
				this.ColliderObject.transform.forward = forward;

				// Starts the FX
				this.ParticleSystems = this.GetComponentsInChildren<ParticleSystem>().ToList();
				this.PlayFX(startPosition, forward);

				// If the move should not stop the attack animation, then we don't want to freeze it and we return 0.
				if(this.Info.IsImmobilizingCaster)
				{
					Transform mainParticleTransform = transform.Find("MainParticle");
	
					if(mainParticleTransform == null)
					{
						Debug.LogError("The move " + moveName + " has no MainParticle child.");
					}
					else
					{
						this.MainParticleSystem = (ParticleSystem)mainParticleTransform.gameObject.GetComponent(typeof(ParticleSystem));
	
						if(this.MainParticleSystem == null)
						{
							Debug.LogError("The MainParticle of the move " + moveName + " contains no ParticleSystem component.");
						}
						else
						{
							animationFreezeDuration = this.MainParticleSystem.duration;
	
							if(animationFreezeDuration > 2)
							{
								Debug.LogError("The MainParticle of " + moveName + " lasts way too long and may cause animation issues.");
							}
						}
					}
				}
			}

			return animationFreezeDuration;
		}

		#endregion

		#region Private methods

		/// <summary>
		/// Updates the position and forward direction of the move
		/// </summary>
		/// <param name="move">Move.</param>
		private void HandleMovement()
		{
			GameObject moveObject = this.gameObject;
			
			// If the move is not immobilizing the caster, move the FX object to the new source position
			if (!this.Info.IsImmobilizingCaster)
			{
				// = this.GetPosition();
				Vector3 newPosition = this.GetPosition();
				this.ColliderObject.transform.position = newPosition;

				if (this.ParticleSystems != null)
				{
					foreach (ParticleSystem particleSystem in ParticleSystems)
					{
						particleSystem.transform.position = newPosition;
					}
				}

			}
			
			// If the move is following the target, change the destination of the move object
			if (this.Info.IsFollowingTarget)
			{
				GameObject targetObject = this.Target.GameObject;

				if (targetObject != null)
				{
					Vector3 newDirection = Vector3.Normalize(targetObject.transform.position - this.Source.CurrentPosition);
					
					// Moves the attack towards the target
					if (this.Info.MovementSpeed > float.Epsilon)
					{
						moveObject.transform.position = moveObject.transform.position + (newDirection * this.Info.MovementSpeed * Time.deltaTime);
					}
					
					switch (this.Info.Shape)
					{
						case MoveShape.Point:
							moveObject.transform.position = targetObject.transform.position;
							break;
							
						case MoveShape.Projectile:
							moveObject.transform.forward = newDirection;
							break;
							
						case MoveShape.Cone:
							moveObject.transform.forward = newDirection;
							break;
							
						case MoveShape.Sphere:
							moveObject.transform.position = targetObject.transform.position - new Vector3(this.Info.Radius, this.Info.Radius, this.Info.Radius);
							break;
							
						case MoveShape.Box:
							moveObject.transform.forward = newDirection;					
							break;
					}
				}
			}
			else
			{
				// If the move is not following the target, updates its position if it is a Projectile or a Sphere
				if (this.Info.Shape == MoveShape.Projectile || this.Info.Shape == MoveShape.Sphere)
				{
					Vector3 movement = moveObject.transform.forward * this.Info.MovementSpeed * Time.deltaTime;					
					moveObject.transform.position = moveObject.transform.position + movement;
				}
			}

			// Rescale the collider based the its alive duration
			if (this.Info.Shape == MoveShape.Cone || this.Info.Shape == MoveShape.Box)
			{
				Collider collider = this.GetComponentInChildren<Collider>();
				float basePercent = Mathf.Clamp(this.CurrentStopDuration / this.MainParticleSystem.duration, 0.0f, 1.0f);
				float endPercent = Mathf.Clamp(this.CurrentDuration / this.MainParticleSystem.duration, 0.0f, 1.0f);

				float centerScale = this.MainParticleSystem.startSpeed * ((endPercent + basePercent) / 2.0f);
				float scaleZ = this.MainParticleSystem.startSpeed * (endPercent - basePercent);

				if (collider is BoxCollider)
				{
					BoxCollider boxCollider = ((BoxCollider) collider);
					boxCollider.center = Vector3.Normalize(boxCollider.center) * centerScale;
					boxCollider.size = new Vector3(boxCollider.size.x, boxCollider.size.y, scaleZ);
				}
			}
		}

		/// <summary>
		/// Handles the collision.
		/// For each detected collision, checks if the move should apply its damage to the collided Pokemon.
		/// </summary>
		private void HandleCollision()
		{
			PokemonController sourceController = this.Source.Controller;

			foreach (Collider collider in this.EnemiesToHit)
			{
				// Retrieves the target PokemonController
				PokemonController targetController = collider.gameObject.GetComponent<PokemonController>();
				if (targetController == null)
				{
					continue;
				}

				// Retrieves the relation of the source pokemon with the target one
				// If the move is not allowed for this relation, go to the next collision
				PokemonRelation relation = sourceController.GetRelation(targetController);
				if ((relation & this.Info.AllowedTargets) == 0)
				{
					continue;
				}

				// Checks the move is only allowed to hit a single pokemon and it has already hit someone
				if (this.Info.HittableTargetsNumber == MoveTargetNumber.One && this.EnemiesHit.Contains(collider))
				{
					continue;
				}

				// Applies the damage
				if (this.Info.EffectType == MoveEffectType.OnHit && this.CurrentDuration > this.Info.Duration * this.Info.DurationPercentEffectsApply)
				{
					// The damage applies on hit and the apply trigger is on
					targetController.SetDamage(this.Info.Damage);
					this.EnemiesHit.Add(collider);
				}
				else if (this.Info.EffectType == MoveEffectType.PerSecond)
				{
					// The damage applies per second
					targetController.SetDamage(this.Info.Damage * Time.deltaTime);
					this.EnemiesHit.Add(collider);
				}
			}
		}

		/// <summary>
		/// Starts all the Particle systems
		/// </summary>
		private void PlayFX(Vector3 startPosition, Vector3 forward)
		{
			this.CurrentDuration = 0f;
			this.CurrentStopDuration = 0f;

			if (this.ParticleSystems != null)
			{
				foreach (ParticleSystem particleSystem in this.ParticleSystems)
				{
					particleSystem.transform.position = startPosition;
					particleSystem.transform.forward = forward;
					particleSystem.Play();
				}
			}
		}

		/// <summary>
		/// Handles FX and destroys the game object if all particles are dead
		/// </summary>
		private void HandleFX()
		{
			// Destroy the dead particles
			if (this.ParticleSystems != null)
			{
				for (int i = 0; i < this.ParticleSystems.Count; i++)
				{
					ParticleSystem particleSystem = this.ParticleSystems[i];

					if (!particleSystem.IsAlive())
					{
						this.ParticleSystems.Remove(particleSystem);
						Destroy(particleSystem);
						i--;
					}
				}

				// If there is no other particle systems available, destroy the game object
				if (this.ParticleSystems.Count == 0)
				{
					Destroy(this.gameObject);
				}
			}
			else
			{
				Destroy(this.gameObject);
			}
		}

		private Vector3 GetPosition()
		{
			Vector3 position = Vector3.zero;

			if (this.Info.Source == MoveSource.Laser)
			{
				position = this.Source.Controller.laserSource.position;
			}
			else if (this.Info.Source == MoveSource.Body)
			{
				position = this.Target.GameObject.transform.position;
			}

			return position;
		}

		#endregion
	}
}