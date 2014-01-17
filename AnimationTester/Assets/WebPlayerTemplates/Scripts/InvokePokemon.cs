using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class InvokePokemon : MonoBehaviour
{
	private GameObject entity;
	//private ModelParameters parameters;
	private Vector3 spawnPosition = new Vector3(4.460348f, 0.2047846f, -9.289039f);
	
	private Dictionary<string, AnimationClip> foundAnimList = new Dictionary<string, AnimationClip>();
	private string laserSourcePath = "";
	private bool isFBX = false;
	private string laserBoneName = "Laser";
	private Dictionary<AttackCategory, float> attackAnimHalfDuration = new Dictionary<AttackCategory, float>();
	
	public string pokemonToInvoke = "Drakkarmin";
	
	// Use this for initialization
	void Start ()
	{
		/* 1) Get the pokemon resource
		 * 2) Create its animator controller from the template
		 * 3) add it its other parameters from his config script (NavMeshAgent, etc)
		 * 4) add his PokemonController script
		 * 5) invoke it
		 */
		
		//entity = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Models/" + pokemonToInvoke + ".blend", typeof(Object));
		entity = (GameObject)Resources.Load("Pokemon/" + pokemonToInvoke);
		if(!entity)
		{
			Debug.LogError("The prefab " + pokemonToInvoke + " of doesn't exist in the Assets/Resources/Pokemon folder.");
			return;
		}

		//parameters = (ModelParameters)entity.GetComponent<ModelParameters>();

		Invoke();
		GetData();
		AddAnimator();
		AddControllerScript();
		AddNavMeshAgent();
	}
	
	/*void OnPostprocessModel(GameObject g)
	{
		// Only operate on Drakkarmin
		if(assetPath.IndexOf("Drakkarmin") == -1)
			return; 

		entity = g;
		AddNavMeshAgent();
	}*/

	void GetData()
	{
		Object[] assetList = AssetDatabase.LoadAllAssetsAtPath("Assets/Models/" + pokemonToInvoke + ".blend");
		if(assetList.Length <= 0)
		{
			isFBX = true;
			assetList = AssetDatabase.LoadAllAssetsAtPath("Assets/Models/" + pokemonToInvoke + ".fbx");
		}
		
		List<string> animList = new List<string>();
		
		animList.Add("Idle");
		animList.Add("Run");
		animList.Add("SpecialAttack");
		
		foreach(Object resource in assetList)
		{
			if(resource.GetType() == typeof(AnimationClip))
			{
				if(animList.Contains(resource.name))
				{
					AnimationClip clip = new AnimationClip();
					bool eventIsPresent = true;

					if(resource.name.Contains("Attack"))
					{
						clip = (AnimationClip)resource;
						AnimationEvent[] evListArray = AnimationUtility.GetAnimationEvents(clip);

						foreach(AnimationEvent ev in evListArray)
						{
							if(ev.functionName == "LaunchAttack")
							{
								attackAnimHalfDuration.Add(attackCategoryStringToEnum(resource.name), clip.length - ev.time);
								eventIsPresent = true;
								break;
							}
						}

						if(!eventIsPresent)
						{
							AnimationEvent ev = new AnimationEvent();
							ev.time = clip.length / 2;
							ev.functionName = "LaunchAttack";
							clip.AddEvent(ev);

							attackAnimHalfDuration.Add(attackCategoryStringToEnum(resource.name), clip.length / 2);

							Debug.LogWarning("Please add the LaunchAttack event to the animation " + resource.name + " of " + pokemonToInvoke + ".");
						}
					}

					if(!eventIsPresent)
					{
						foundAnimList.Add(resource.name, clip);
					}
					else
					{
						foundAnimList.Add(resource.name, (AnimationClip)resource);
					}

					animList.Remove(resource.name);
				}
			}
			
			if(resource.GetType() == typeof(Transform) && resource.name == laserBoneName)
			{
				//laserSource = (Transform)resource;
				Transform parent = ((Transform)resource).parent;
				laserSourcePath = laserBoneName;
				while(parent.name != "Armature")
				{
					laserSourcePath = parent.name + "/" + laserSourcePath;
					parent = parent.parent;
				}
			}
		}

		if(animList.Count > 0)
		{
			foreach(string animName in animList)
				Debug.LogWarning("Missing " + animName + " animation for " + pokemonToInvoke + ".");
		}
		
		if(laserSourcePath == "")
			Debug.LogWarning("Missing " + laserBoneName + " bone for " + pokemonToInvoke + ".");
		
		// Here we auto-configure the animation clips.
		/*{
			if(foundAnimList["Idle"])
			{
				foundAnimList["Idle"].wrapMode = WrapMode.Loop;
			}

			if(foundAnimList["Run"])
			{
				foundAnimList["Run"].wrapMode = WrapMode.Loop;
			}

			if(foundAnimList["SpecialAttack"])
			{
				AnimationClip anim = foundAnimList["SpecialAttack"];
				AnimationEvent ev = new AnimationEvent();

				// Add the first event.
				ev.functionName = "LaunchAttack";
				ev.time = anim.length * 0.5f;
				anim.AddEvent(ev);

				// Add the second event.
				ev.functionName = "EndOfAttack";
				ev.time = anim.length * 0.9f;
				anim.AddEvent(ev);
			}
		}*/
	}
	
	void AddAnimator()
	{
		UnityEditorInternal.AnimatorController animatorController = (UnityEditorInternal.AnimatorController)Resources.Load("Animator/Template");
		UnityEditorInternal.StateMachine sm = animatorController.GetLayer(0).stateMachine;
		
		UnityEditorInternal.State state;
		int i = 0;
		while(i < foundAnimList.Count && (state = sm.GetState(i)))
		{
			state.SetAnimationClip(foundAnimList[state.name]);
			i++;
		}
		
		Animator animator = (Animator)entity.GetComponent("Animator");
		if(!animator)
			animator = (Animator)entity.AddComponent<Animator>();
		
		animator.runtimeAnimatorController = animatorController;
	}
	
	void AddNavMeshAgent()
	{
		NavMeshAgent nav = entity.GetComponent<NavMeshAgent>();
		if(!nav)
			nav = (NavMeshAgent)entity.AddComponent("NavMeshAgent");
		
		nav.radius = 5f;
		nav.height = 20f;
		
		nav.stoppingDistance = 0f;
		
		nav.speed = 5f;
		
		if(isFBX)
			nav.acceleration = 100f * nav.speed;
		else
			nav.acceleration = 1000f * nav.speed;
		
		nav.angularSpeed = 0f;
		
		nav.autoBraking = false;
	}
	
	void AddControllerScript()
	{
		PokemonController script = (PokemonController)entity.GetComponent("PokemonController");
		if(!script)
			script = (PokemonController)entity.AddComponent<PokemonController>();
		
		script.laserSourcePath = laserSourcePath;
		script.attackAnimHalfDuration = attackAnimHalfDuration;
	}
	
	void Invoke()
	{
		/*if(isFBX)
			entity.transform.localScale = new Vector3(20f, 20f, 20f);
		else
			entity.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);*/
		entity = (GameObject)Instantiate((Object)entity, spawnPosition, new Quaternion());
		entity.tag = "CameraTarget";
		entity.transform.parent = GameObject.Find("Pokemon").transform;
		PrefabUtility.ReplacePrefab(entity, Resources.Load("Pokemon/" + pokemonToInvoke));
	}

	AttackCategory attackCategoryStringToEnum(string str)
	{
		switch(str)
		{
			case "PhysicalAttack":
				return AttackCategory.Physical;

			case "SpecialAttack":
				return AttackCategory.Special;

			case "StatusAttack":
				return AttackCategory.Status;

			default:
				return AttackCategory.ERROR;
		}
	}
}
