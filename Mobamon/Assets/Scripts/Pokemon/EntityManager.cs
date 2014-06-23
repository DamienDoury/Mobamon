using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.GameManager;
using Mobamon.Moves;
using Mobamon.Database;
using Mobamon.Database.Enums;

namespace Mobamon.Pokemon
{
    /*
     * This class is attached to each single entity.
     * 
     * An entity is everything that lives and dies.
     * It can be targetted and killed by another entity.
     * It always belongs to a team.
     * They have to own a collider and a network view.
     * 
     * It has to be into the Entities container in the Scene.
     */

    public class EntityManager : MonoBehaviour
    {
        #region Public fields
        public int team { get; set; }
		public Stats stats { get; set; }

        public float maxHP		
		{
			get
			{
				return stats.hp;
			}

			set
			{
				stats.hp = (int)value;
			}
		}
        public float currentHP { get; set; }
        public float regenRate { get; set; } // in % of max health/sec.
        #endregion

        #region Private fields
        private bool blinkAfterDamage = false;
        private float blinkDuration = 0f;
        private float blinkMaxDuration = 0.5f;
        private int numberOfBlinks = 1;
        private Color originalColor = new Color(0.8f, 0.8f, 0.8f, 1f);
		private List<DamageInfo> damageHistory = new List<DamageInfo>();
        #endregion 

        #region Protected methods
        protected void Awake ()
        {
            team = 0;
			stats = new Stats ();
        }
        
        protected void Start ()
        {           
            regenRate = 0.05f;
            maxHP = 300f;
            currentHP = maxHP;
    	}
    	
        protected void Update ()
        {
            RegenHP();
            BlinkAfterDamage();
    	}
        #endregion

        #region Public methods
        [RPC]
        public void SetDamage(float dmg, EntityManager caster)
        {
            float newLife = Mathf.Max(0, currentHP - dmg);
			damageHistory.Add(new DamageInfo(dmg, caster));
            this.gameObject.networkView.RPC("SetLife", RPCMode.All, newLife);
        }

        /// <summary>
        /// Returns if the pokemon is an ally, an ennemy or neutral
        /// </summary>
        /// <returns>The relation.</returns>
        /// <param name="pokemon">The Pokemon GameObject.</param>
        public PokemonRelation GetRelation(GameObject pokemon)
        {
            EntityManager em = pokemon.GetComponent<EntityManager>();
            
            if(em == null)
            {
                return PokemonRelation.ERROR;
            }
            else if(this == em)
            {
                return PokemonRelation.Self;
            }
            else
            {
                if(em.team == team)
                {
                    return PokemonRelation.Ally;
                }
                else
                {
                    return PokemonRelation.Enemy; // Neutral monsters will also be considered as enemies.
                }
            }
        }

        public void ResetBlinking()
        {
            blinkAfterDamage = false;
            
            Renderer rend = (Renderer)gameObject.GetComponentInChildren(typeof(Renderer));
            Material[] matList = rend.materials;
            foreach(Material mat in matList)
                mat.color = originalColor;
        }

		public void Respawn() // Is called by Respawn() from TheReaper
		{
			currentHP = maxHP;
			ResetBlinking();
			damageHistory.Clear();
		}

		public void GrantKill()
		{
			stats.xp += 100;

			if(stats.xp >= 100 * stats.lvl)
				stats.lvl++;
		}
        #endregion

        #region Private methods
        private void RegenHP()
        {
            currentHP = Mathf.Min(maxHP, currentHP + maxHP * regenRate * Time.deltaTime);
        }
        
        [RPC]
        private void SetLife(float life)
        {
            currentHP = Mathf.Clamp(life, 0, maxHP);

            if(currentHP <= 0)
            {
                if(Network.isServer)
                    Die();
            }
            else
            {
                StartBlinking();
            }
        }

        private void Die()
        {
			// We look for the Enemy who made the more damage and grant him the kill.
			EntityManager killer = null;
			float killerDamage = 0;

			Dictionary<EntityManager, float> accomplices = new Dictionary<EntityManager, float>();
			foreach(DamageInfo damageSource in damageHistory)
			{
				EntityManager caster = damageSource.caster;
				float amount = damageSource.amount;

				if(caster.team != this.team && caster.team != 0) // If this damage comes from an opponent...
				{
					if(accomplices.ContainsKey(caster) == false)
					{
						accomplices.Add(caster, amount);
					}
					else
					{
						accomplices[caster] += amount;
					}

					if(accomplices[caster] > killerDamage)
					{
						killerDamage = accomplices[caster];
						killer = caster;
					}
				}
			}

            if(Network.isServer)
                TheReaper.instance.NoticeDeath(this, killer);

            /*Invoke("Respawn", 3f);
            gameObject.SetActive(false);*/
        }
        
        private void StartBlinking()
        {
            blinkAfterDamage = true;
            blinkDuration = 0f;
        }
        
        private void BlinkAfterDamage()
        { 
            if(!blinkAfterDamage)
                return;
            
            if(blinkDuration <= 0f)
                blinkDuration = blinkMaxDuration * numberOfBlinks * 2 - blinkMaxDuration; // Add " - blinkMaxDuration" to start from the red color.
            
            blinkDuration -= Time.deltaTime;
            
            Renderer rend = (Renderer)GetComponentInChildren(typeof(Renderer));
            Material[] matList = rend.materials;
            foreach(Material mat in matList)
            {
                float lerp = Mathf.PingPong(blinkDuration, blinkMaxDuration) / blinkMaxDuration;
                mat.color = Color.Lerp(originalColor, Color.red, lerp);
                //mat.Lerp(mat, dmgMat, lerp);
                //mat = dmgMat;
                // Alternate solution: Material.Lerp() with a plain red template material.
            }
            
            /*for(int i = 0; i < matList.Length; i++)
                    matList[i].SetTexture("_MainTex", dmgMat.GetTexture("_MainTex"));

                for(int i = 0; i < matList.Length; i++)
                    matList[i].CopyPropertiesFromMaterial(dmgMat);*/
            
            if(blinkDuration <= 0f)
            {
                ResetBlinking();
            }
        }

        private void OnParticleCollision(GameObject particle)
        {
            if(Network.isServer)
            {
                if(particle.name.Equals("MainParticle"))
                {
                    Transform move = particle.transform;
                    
                    while(move.parent.name != "Moves")
                        move = move.parent;
                    
                    DamageManager man = move.GetComponent<DamageManager>();
                    man.HasCollided(gameObject);
                }
            }
        }
        #endregion
    }
}
