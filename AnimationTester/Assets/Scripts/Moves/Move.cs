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
		private List<PokemonController> EnemiesHit { get; set; }
		
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
		
		#endregion
		
		#region Public methods
		
		/// <summary>
		/// Start this instance.
		/// </summary>
		public void Start()
		{
			this.EnemiesHit = new List<PokemonController>();
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
				this.HandleCollision();
				this.HandleFX();
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
				this.IsRunning = true;
				this.Source = source;
				this.Target = target;
				
				// Positions the Attack gameobject
				this.transform.position = this.GetPosition();
				this.transform.forward = source.GameObject.transform.forward;
				
				// Starts the FX
				this.ParticleSystems = this.GetComponentsInChildren<ParticleSystem>().ToList();
				this.PlayFX();
				
				// Retrieves the MainParticle
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
						// If the move should not stop the attack animation, then we don't want to freeze it and we return 0.
						if(this.Info.IsImmobilizingCaster)
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
			
			// If the move is not immobilizing the caster, move the move object to the new source position
			if (!this.Info.IsImmobilizingCaster)
			{
				moveObject.transform.position = this.GetPosition();
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
						float radius = (this.Info.AdditionalData as SphereData).Radius;
						moveObject.transform.position = targetObject.transform.position - new Vector3(radius, radius, radius);
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
		}
		
		/// <summary>
		/// Handles the collision.
		/// For each detected collision, checks if the move should apply its damage to the collided Pokemon.
		/// </summary>
		private void HandleCollision()
		{
			PokemonController sourceController = this.Source.Controller;
			PokemonController[] pokemons = null;
			
			// This is a special case, the attack is meant to damage only the target, so there is no collision to check on the other pokemons
			if (this.Info.Shape == MoveShape.Point && this.Info.HittableTargetsNumber == MoveTargetNumber.One && this.Info.IsFollowingTarget)
			{
				pokemons = new PokemonController[] { this.Target.Controller };
			}
			else
			{
				GameObject pokemonsContainer = GameObject.Find("/Pokemon");
				pokemons = pokemonsContainer.GetComponentsInChildren<PokemonController>();
			}
			
			// Calculates the min and max range percent
			float minPercent = Mathf.Clamp(this.CurrentStopDuration / this.MainParticleSystem.duration, 0.0f, 1.0f);
			float maxPercent = Mathf.Clamp(this.CurrentDuration / this.MainParticleSystem.duration, 0.0f, 1.0f);
			
			// Checks each pokemon in the game
			foreach (PokemonController pokemon in pokemons) 
			{
				bool isColliding = false;
				
				if (this.Info.Shape == MoveShape.Cone && this.Info.AdditionalData is ConeData)
				{
					// Checks if the pokemon is colliding with a cone
					isColliding = this.IsCollidingWithCone(pokemon, minPercent, maxPercent);
				}
				else if (this.Info.Shape == MoveShape.Point && this.Info.HittableTargetsNumber == MoveTargetNumber.One && this.Info.IsFollowingTarget)
				{
					// The attack is a point following the target, so the target is always colliding
					isColliding = true;
				}
				
				if (isColliding)
				{
					// Retrieves the relation of the source pokemon with the target one
					// If the move is not allowed for this relation, go to the next collision
					PokemonRelation relation = sourceController.GetRelation(pokemon);
					if ((relation & this.Info.AllowedTargets) == 0)
					{
						continue;
					}
					
					// Checks the move is only allowed to hit a single pokemon and it has already hit someone
					if (this.Info.HittableTargetsNumber == MoveTargetNumber.One && this.EnemiesHit.Contains(pokemon))
					{
						continue;
					}
					
					// Applies the damage
					if (this.Info.EffectType == MoveEffectType.OnHit && this.CurrentDuration > this.Info.Duration * this.Info.DurationPercentEffectsApply)
					{
						// The damage applies on hit and the apply trigger is on
						pokemon.SetDamage(this.Info.Damage);
						this.EnemiesHit.Add(pokemon);
					}
					else if (this.Info.EffectType == MoveEffectType.PerSecond)
					{
						// The damage applies per second
						pokemon.SetDamage(this.Info.Damage * Time.deltaTime);
						this.EnemiesHit.Add(pokemon);
					}
				}
			}
		}
		
		/// <summary>
		/// Determines whether this instance is colliding with a cone.
		/// </summary>
		/// <returns><c>true</c> if this instance is colliding with a cone.
		/// otherwise, <c>false</c>.</returns>
		/// <param name="target">The target PokemonController.</param>
		/// <param name="minRangePercent">Minimum range percent.</param>
		/// <param name="maxRangePercent">Max range percent.</param>
		private bool IsCollidingWithCone(PokemonController target, float minRangePercent, float maxRangePercent)
		{
			Vector2 sourcePosition = this.Source.CurrentPosition.ToVector2_XZ();
			Vector2 targetPosition = target.transform.position.ToVector2_XZ();
			Vector2 sourceForward = this.Source.GameObject.transform.forward.ToVector2_XZ();
			
			float attackRange = this.MainParticleSystem.startSpeed;
			float attackMinRange = attackRange * minRangePercent;
			float attackMaxRange = attackRange * maxRangePercent;
			float distance = Vector2.Distance (sourcePosition, targetPosition);
			float enemyRadius = target.radius;
			
			float halfAngle = (this.Info.AdditionalData as ConeData).HalfAngle;
			Vector2 sourceTargetVector = targetPosition - sourcePosition;
			float angle = Vector2.Angle(sourceTargetVector, sourceForward);
			
			// If the enemy is in range, deals damage to it
			return ((distance - enemyRadius) < attackMaxRange 
			        && (distance + enemyRadius) > attackMinRange
			        && (angle <= halfAngle || angle >= 360 - halfAngle));
		}
		
		/// <summary>
		/// Starts all the Particle systems
		/// </summary>
		private void PlayFX()
		{
			this.CurrentDuration = 0f;
			this.CurrentStopDuration = 0f;
			
			if (this.ParticleSystems != null)
			{
				foreach (ParticleSystem particleSystem in this.ParticleSystems)
				{
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
		
		/// <summary>
		/// Gets the position of the move object.
		/// </summary>
		/// <returns>The position.</returns>
		private Vector3 GetPosition()
		{
			Vector3 position = Vector3.zero;
			
			switch (this.Info.Source) 
			{
			case MoveSource.Area:
				position = this.Source.StartPosition;
				break;
			case MoveSource.CasterBody:
				position = this.Source.CurrentPosition;
				break;
			case MoveSource.TargetBody:
				position = this.Target.CurrentPosition;
				break;
			case MoveSource.Laser:
				position = this.Source.Controller.laserSource.position;
				break;
			default:
				Debug.LogError("Invalid move source");
				break;
			}
			
			return position;
		}
		
		#endregion
	}
}