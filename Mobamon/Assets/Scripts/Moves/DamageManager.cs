using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Pokemon.Player;
using Mobamon.Database;
using Mobamon.Database.Classes;
using Mobamon.Database.Enums;
using Mobamon.Moves;
using Mobamon.Pokemon;

namespace Mobamon.Moves
{
    public class DamageManager : MonoBehaviour
    {
        #region Public Fields
        public MoveTarget caster { get; set; }
        public MoveTarget target { get; set; }
        
        /// <summary>
        /// The list of Pokemons hit by a particles of a non Single Target move.
        /// </summary>
        public List<GameObject> hitTargetList = new List<GameObject>();
        #endregion
        
        #region Private Fields
        private string moveName = "ERROR";
        private MoveInfo moveInfo = new MoveInfo();
        
        /// <summary>
        /// Time before the damage of a Single Target move is applied, so it matches its animation/FX.
        /// </summary>
        /// <value>The time is seconds.</value>
        private float timeBeforeDamage = 0f;
        #endregion
        
        #region Protected Methods
        protected void Start()
        {
            
        }
        
        /// <summary>
        /// Apply the damage at the right time for the Single Target moves.
        /// </summary>
        protected void Update()
        {
            if(Network.isServer)
            {
                // Securities
                if(caster == null)
                {
                    Debug.LogError("The move '" + moveName + "' has no caster attached!");
                    return;
                }
                
                // Here we trigger the damage of the Single Target moves.
                if(moveInfo.TargetKind == MoveTargetKind.Single
                   && timeBeforeDamage > 0)
                {
                    timeBeforeDamage -= Time.deltaTime;
                    
                    // Damage calculation
                    if(timeBeforeDamage <= 0
                       && (moveInfo.AllowedTargets & caster.EntityManager.GetRelation(target.GameObject)) != 0)
                    {
                        if(moveInfo.EffectType == MoveEffectType.OnHit)
                        {
                            target.EntityManager.SetDamage(moveInfo.Damage, caster.EntityManager);
                        }
                        else if(moveInfo.EffectType == MoveEffectType.PerSecond)
                        {
                            target.EntityManager.SetDamage(moveInfo.Damage, caster.EntityManager);
                        }
                    }
                }
            }
        }
        #endregion
        
        #region Public Methods
        /// <summary>
        /// Stores the caster and the target of the move.
        /// This method has to be called directly upon creation of this DamageManager component.
        /// </summary>
        /// <param name="_moveName">Move's name.</param>
        /// <param name="_caster">Caster's MoveTarget.</param>
        /// <param name="_target">Target's MoveTarget.</param>
        public void SetParameters(string _moveName, MoveTarget _caster, MoveTarget _target)
        {
            if(!Attackdex.move.ContainsKey(_moveName))
                Debug.LogError("The move '" + _moveName + "' is not registered in the Attackdex.");
            else
            {
                moveName = _moveName;
                moveInfo = Attackdex.move[moveName];
                if(moveInfo.TargetKind == MoveTargetKind.Single)
                    timeBeforeDamage = moveInfo.DelayBeforeDamage;
            }
            
            caster = _caster;
            target = _target;
            
            if(moveInfo.TargetKind != MoveTargetKind.Single) // We assume that those spells can't deal damage to several targets.
            {
                foreach(ParticleSystem ps in this.GetComponentsInChildren<ParticleSystem>())
                {
                    if(ps.name == "MainParticle")
                    {
                        TransmitCollisionMessage script = ps.gameObject.AddComponent<TransmitCollisionMessage>();
                        script.SetManager(this.GetComponent<DamageManager>());
                    }
                }
            }
        }
        
        /// <summary>
        /// Is called when a collision has occured between this move's particles and a Pokemon's collider.
        /// Apply the damage for the non Single Target moves.
        /// </summary>
        /// <param name="victim">The GameObject of the hit Pokemon.</param>
        public void HasCollided(GameObject victim)
        {
            if(Network.isServer)
            {
                // Securities
                if(caster == null)
                {
                    Debug.LogError("The move '" + moveName + "' has no caster attached!");
                    return;
                }
                
                if(moveInfo.TargetKind == MoveTargetKind.Single)
                    return;
                
                if(moveInfo.HittableTargetsNumber == MoveTargetNumber.One && hitTargetList.Count > 0)
                    return;
                
                EntityManager victimManager = victim.GetComponent<EntityManager>();
                
                if(victimManager != null)
                {
                    // Damage calculation
                    if((moveInfo.AllowedTargets & caster.EntityManager.GetRelation(victimManager.gameObject)) != 0 
                       && !hitTargetList.Contains(victim))
                    {
                        hitTargetList.Add(victim);
                        
                        if(moveInfo.EffectType == MoveEffectType.OnHit)
                        {
                            victimManager.SetDamage(moveInfo.Damage, caster.EntityManager);
                        }
                        else if(moveInfo.EffectType == MoveEffectType.PerSecond)
                        {
							victimManager.SetDamage(moveInfo.Damage, caster.EntityManager);
                        }
                    }
                }
            }
        }
        #endregion
    }
}