using UnityEngine;
using System.Collections;
using Mobamon.Moves;
using Mobamon.Database;
using Mobamon.Database.Enums;

public class TransmitCollisionMessage : MonoBehaviour
{
    #region Private Fields
    /// <summary>
    /// The DamagerManager script to send the collision messages to.
    /// </summary>
    private DamageManager manager = null;

    /// <summary>
    /// Set to true if this ParticleSystem sends collision messages.
    /// </summary>
    private bool sendsCollisionMessages = false;

    /// <summary>
    /// Used for the Pass Through moves. 
    /// We calculate the collision of these particles manually, on a 2D surface.
    /// </summary>
    private ParticleSystem collisionParticle = new ParticleSystem();
    
    /// <summary>
    /// The GameObject that is used as a container for all the players' Pokemon.
    /// </summary>
    private GameObject entitiesContainer = null;
    #endregion

    public void SetManager(DamageManager _manager)
    {
        manager = _manager;
    }

    #region Protected Methods
	protected void Start()
    {
        entitiesContainer = SceneHelper.GetContainer(Container.Entities);
        collisionParticle = this.GetComponent<ParticleSystem>();
	}
	
    protected void FixedUpdate()
    {
        // Here we calculate the collision of the Pass Through moves.
        CheckParticleCollision();
	}
    #endregion

    #region Private Methods
    /// <summary>
    /// Automatically called when a particle has "Send collision messages" set up.
    /// </summary>
    /// <param name="victim">The struck entity.</param>
    private void OnParticleCollision(GameObject victim)
    {
        if(Network.isServer)
        {
            sendsCollisionMessages = true;

            if(victim == manager.caster.GameObject)
                return;

            if(victim.transform.parent.parent.gameObject != SceneHelper.GetContainer(Container.Entities))
                return;

            if(!manager.hitTargetList.Contains(victim))
                manager.HasCollided(victim);
        }
    }
    
    private void CheckParticleCollision()
    {
        if(Network.isServer) // && !sendsCollisionMessages)
        {
            if(collisionParticle.particleCount <= 0)
            {
                return;
            }

            ParticleSystem.Particle[] particlesArray = new ParticleSystem.Particle[collisionParticle.particleCount];      
            collisionParticle.GetParticles(particlesArray);
            
            foreach(SphereCollider collider in entitiesContainer.GetComponentsInChildren<SphereCollider>()) // For each pkmn with a collider ...
            {
                // In Unity 4.3.2, we cannot know if the ParticleSystem sends collision messages.
                // Thus, we get the safeCollisionEventSize. If it's greater than zero, then the ParticleSystem sends messages.
                if(collisionParticle.safeCollisionEventSize > 0)
                {
                    sendsCollisionMessages = true;
                    return;
                }

                // If this pkmn has already taken damage, we skip the particle collision.
                GameObject victim = collider.gameObject;               

                if(victim == manager.caster.GameObject)
                    continue;

                if(manager.hitTargetList.Contains(victim))
                    continue;
                
                for(int i = 0; i < collisionParticle.particleCount; i++) // We loop through the particles of this attack that should collide.
                {
                    Vector3 particlePos = particlesArray[i].position;
                    if(collisionParticle.simulationSpace == ParticleSystemSimulationSpace.Local)
                        particlePos += manager.transform.position;
                    particlePos.Set(particlePos.x, 0f, particlePos.z);

                    Vector3 colliderPos = collider.center + collider.transform.position; // The world position of the collider.
                    colliderPos.Set(colliderPos.x, 0f, colliderPos.z);

                    // !!! We need to take the particle's radius into account.
                    if(Vector3.Distance(colliderPos, particlePos) <= collider.radius) // If the center of the particle is within the collider.
                    {
                        if(!manager.hitTargetList.Contains(victim))
                        {
                            manager.HasCollided(victim);
                            break;
                        }
                    }
                }
            }  
        }
        
        //collisionParticle.SetParticles(particlesArray, collisionParticle.particleCount);
    }
    #endregion
}
