using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class InvokePokemon : MonoBehaviour
{
	private static GameObject entity;
	private static Vector3 spawnPosition = new Vector3(4.460348f, 0.2047846f, -9.289039f);
	
	private static Dictionary<string, AnimationClip> foundAnimList;
	private static string laserSourcePath;
	private static bool isFBX;
	private static string laserBoneName = "Laser";
	private static Dictionary<AttackCategory, float> attackAnimHalfDuration;	
	private static string pokemonToInvoke = "";
	private static string modelsFolder = "Assets/Models/";

	private static bool generateAll = false;
	private static string pokemonToGenerate = "";
	
	// Use this for initialization
	/*void Start ()
	{
		if(generateAll)
			GottaGenerateThemAll();
		else if(pokemonToGenerate != "")
			GeneratePlayablePokemon(pokemonToGenerate);
	}*/

	[MenuItem ("CustomFeatures/Generate All Pokemon Models")]
	static void GottaGenerateThemAll()
	{
		string[] assetList = AssetDatabase.GetAllAssetPaths();
		foreach(string asset in assetList)
		{
			if(asset.StartsWith(modelsFolder)
			   && (asset.EndsWith(".blend") || asset.EndsWith(".fbx")))
			{
				string pokemonName = asset.Replace(modelsFolder, "").Replace(".blend", "").Replace(".fbx", "");
				GeneratePlayablePokemon(pokemonName);
			}
		}
	}

	static void GeneratePlayablePokemon(string pokemonName)
	{
		pokemonToInvoke = pokemonName;

		if(pokemonToInvoke == "")
			return;
		
		entity = (GameObject)Resources.Load("Pokemon/" + pokemonToInvoke);

		InitializeAttributes();
		if(GetData())
		{
			if(entity == null)
				CreatePrefab();
			Invoke();
			
			AddAnimator();
			AddControllerScript();
			AddNavMeshAgent();
			AddNetworkView();
			AddCollider();
			
			SavePrefab();
			DestroyEntity();
		}
	}

	static void InitializeAttributes()
	{
		laserSourcePath = "";
		isFBX = false;
		attackAnimHalfDuration = new Dictionary<AttackCategory, float>();
		foundAnimList = new Dictionary<string, AnimationClip>();
	}
	
	static bool GetData() // Returns TRUE if the model is OK and we should generate it.
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
				Debug.LogError("Missing " + animName + " animation for " + pokemonToInvoke + ".");
		}
		else
		{
			if(!foundAnimList["Idle"].isLooping)
				Debug.LogError("The Idle animation of " + pokemonToInvoke + " is not looping. Please make it loop.");

			if(!foundAnimList["Run"].isLooping)
				Debug.LogError("The Run animation of " + pokemonToInvoke + " is not looping. Please make it loop.");
		}
		
		if(laserSourcePath == "")
			Debug.LogError("Missing " + laserBoneName + " bone for " + pokemonToInvoke + ".");

		// !! DOESN'T WORK !! Here we auto-configure the animation clips.
		/*{
			if(foundAnimList["Idle"])
			{

				Motion truc = (Motion)Motion.Instantiate(foundAnimList["Idle"]);
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

				ev.functionName = "LaunchAttack";
				ev.time = anim.length * 0.5f;
				anim.AddEvent(ev);
			}
		}*/

		if(animList.Count == 0 && laserSourcePath != "")
		{
			if(foundAnimList.ContainsKey("Idle") && foundAnimList["Idle"].isLooping == true
			   && foundAnimList.ContainsKey("Run") && foundAnimList["Run"].isLooping == true)
				// We gotta check if the event "LaunchAttack" exists.
				return true;
			else
				return false;
		}
		else
			return false;
	}

	static void CreatePrefab()
	{
		PrefabUtility.CreatePrefab("Assets/Resources/Pokemon/" + pokemonToInvoke + ".prefab", (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Models/" + pokemonToInvoke + (isFBX ? ".fbx" : ".blend"), typeof(Object)));
		entity = (GameObject)Resources.Load("Pokemon/" + pokemonToInvoke);

		if(entity == null)
		{
			Debug.LogError("The prefab " + pokemonToInvoke + " of doesn't exist in the Assets/Resources/Pokemon folder.");
			return; // Unfortunately, this won't stop the program.
		}
		
		if(isFBX)
			entity.transform.localScale = new Vector3(20f, 20f, 20f);
		else
			entity.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
	}
	
	static void Invoke()
	{
		entity = (GameObject)Instantiate((Object)entity, spawnPosition, new Quaternion());
		entity.transform.parent = GameObject.Find("Pokemon").transform;
	}
	
	static void AddAnimator()
	{
		if(AssetDatabase.LoadAssetAtPath("Assets/Resources/Animator/" + pokemonToInvoke + ".controller", typeof(UnityEditorInternal.AnimatorController)) == null)
		{
			//AssetDatabase.CopyAsset("Assets/Resources/Animator/Template.controller", "Assets/Resources/Animator/" + pokemonToInvoke + ".controller");
			AssetDatabase.CreateAsset(Instantiate(Resources.Load("Animator/Template")), "Assets/Resources/Animator/" + pokemonToInvoke + ".controller");

			UnityEditorInternal.AnimatorController animatorController = (UnityEditorInternal.AnimatorController)Resources.Load("Animator/" + pokemonToInvoke);
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
	}
	
	static void AddNavMeshAgent()
	{
		NavMeshAgent nav = entity.GetComponent<NavMeshAgent>();
		if(!nav)
			nav = (NavMeshAgent)entity.AddComponent("NavMeshAgent");

		if(isFBX)
		{
			nav.radius = 0.05f;
			nav.height = 0.2f;
		}
		else
		{
			nav.radius = 5f;
			nav.height = 20f;
		}
		
		nav.stoppingDistance = 0f;
		
		nav.speed = 5f;
		
		if(isFBX)
			nav.acceleration = 100f * nav.speed;
		else
			nav.acceleration = 1000f * nav.speed;
		
		nav.angularSpeed = 0f;
		
		nav.autoBraking = false;
	}
	
	static void AddControllerScript()
	{
		PokemonController script = (PokemonController)entity.GetComponent("PokemonController");
		if(!script)
			script = (PokemonController)entity.AddComponent<PokemonController>();
		
		script.laserSourcePath = laserSourcePath;
		script.attackAnimHalfDuration = attackAnimHalfDuration;
	}

	static void AddNetworkView()
	{
		NetworkView view = (NetworkView)entity.GetComponent(typeof(NetworkView));
		if(!view)
			view = (NetworkView)entity.AddComponent<NetworkView>();

		view.stateSynchronization = NetworkStateSynchronization.Off;
	}

	static void AddCollider()
	{
		if((Collider)entity.GetComponent(typeof(Collider)) != null)
			return;

		SphereCollider sphereCollider = (SphereCollider)entity.AddComponent<SphereCollider>();

		if(isFBX)
		{
			sphereCollider.radius = 0.05f;
			sphereCollider.center = new Vector3(0f, 0.05f, 0f);
		}
		else
		{
			sphereCollider.radius = 5f;
			sphereCollider.center = new Vector3(0f, 5f, 0f);
		}
	}

	static void SavePrefab()
	{
		PrefabUtility.ReplacePrefab(entity, Resources.Load("Pokemon/" + pokemonToInvoke));
	}

	static void DestroyEntity()
	{
		entity.name = "_" + entity.name;
		Destroy(entity); // Doesn't succeed because no Update() is called.
	}

	static AttackCategory attackCategoryStringToEnum(string str)
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
