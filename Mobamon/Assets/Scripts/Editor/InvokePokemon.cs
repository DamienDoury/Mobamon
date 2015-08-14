using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mobamon.Database;
using Mobamon.Database.Enums;
using Mobamon.Pokemon.Player;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using Mobamon.Editor.Structs;

namespace Mobamon.Editor
{
    //public class InvokePokemon : MonoBehaviour
    //{
    //    #region Constants

    //    /// <summary>
    //    /// The models folder.
    //    /// </summary>
    //    private static readonly string ModelsFolder = "Assets/Models/Pokemons/";

    //    /// <summary>
    //    /// The prefabs folder.
    //    /// </summary>
    //    private static readonly string PrefabsFolder = "Assets/Resources/Pokemons/";

    //    /// <summary>
    //    /// The animators folder.
    //    /// </summary>
    //    private static readonly string AnimatorsFolder = "Assets/Animators/Pokemons/";

    //    /// <summary>
    //    /// The template animator path.
    //    /// </summary>
    //    private static readonly string TemplateAnimatorPath = "Assets/Templates/Animators/Template.controller";

    //    /// <summary>
    //    /// The model extensions.
    //    /// </summary>
    //    private static readonly string[] ModelExtensions = { ".blend", ".fbx" };

    //    /// <summary>
    //    /// The model animations.
    //    /// </summary>
    //    private static readonly string[] ModelAnimations = { "Idle", "Run", "SpecialAttack", "PhysicalAttack" };

    //    /// <summary>
    //    /// The name of the launch attack event.
    //    /// </summary>
    //    private static readonly string LaunchAttackEventName = "LaunchAttack";

    //    /// <summary>
    //    /// The name of the laser bone.
    //    /// </summary>
    //    private static readonly string LaserBoneName = "Laser";

    //     #endregion


    //    /*public static void ImportPokemonBlend()
    //    {
    //        string fileToImport = EditorUtility.OpenFilePanel("Choose a Pokemon model file", "", ".blend|Blend file|*.fbx|FBX file");
    //    }

    //    /// <summary>
    //    /// Imports the file.
    //    /// </summary>
    //    /// <param name="filePath">File path.</param>
    //    private static void ImportFile(string filePath)
    //    {
    //        string folderPath = Path.GetDirectoryName(filePath);
    //        string extension = Path.GetExtension(filePath);

    //        //AssetDatabase.ImportAsset(filePath, ImportAssetOptions.ForceSynchronousImport);
    //    }*/

    //    /// <summary>
    //    /// Generates all the assets and prefabs for each Pokemon models
    //    /// </summary>
    //    [MenuItem("Import/Generate playable Pokemons from models")]
    //    public static void GottaGenerateThemAll()
    //    {
    //        string[] assetList = AssetDatabase.GetAllAssetPaths();
    //        foreach(string asset in assetList)
    //        {
    //            if(asset.StartsWith(ModelsFolder) && (asset.EndsWith(".blend") || asset.EndsWith(".fbx")))
    //            {
    //                string pokemonName = asset.Replace(ModelsFolder, "");
    //                string extension = null;

    //                if (ModelExtensions != null && ModelExtensions.Length > 0)
    //                {
    //                    foreach (string modelExtension in ModelExtensions)
    //                    {
    //                        if (pokemonName.EndsWith(modelExtension))
    //                        {
    //                            extension = modelExtension;
    //                            pokemonName = pokemonName.Replace(extension, "");
    //                            break;
    //                        }
    //                    }
    //                }

    //                GeneratePlayablePokemon(pokemonName, extension);
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// Generates the playable pokemon.
    //    /// </summary>
    //    /// <param name="pokemonName">Pokemon name.</param>
    //    /// <param name="extension">Extension.</param>
    //    private static void GeneratePlayablePokemon(string pokemonName, string extension)
    //    {
    //        GameObject existingPrefab = null;
    //        string laserSourcePath = null;
    //        Dictionary<string, AnimationClip> foundAnimations = null;
    //        Dictionary<MoveCategory, float> attackAnimHalfDuration = null;
                        
    //        string prefabPath = string.Format("{0}{1}.prefab", PrefabsFolder, pokemonName);
    //        string modelPath = string.Format("{0}{1}{2}", ModelsFolder, pokemonName, extension);
    //        string animatorPath = string.Format("{0}{1}.controller", AnimatorsFolder, pokemonName);

    //        // Checks if the pokemon name is valid
    //        if (string.IsNullOrEmpty(pokemonName))
    //            return;

    //        existingPrefab = Resources.LoadAssetAtPath<GameObject>(prefabPath);

    //        // If there is no existing prefab, then the Pokemon hasn't been generated yet
    //        GameObject prefab = null;

    //        if (existingPrefab == null)
    //        {
    //            CreatePrefab(modelPath, prefabPath, pokemonName, out prefab);
    //        }
    //        else
    //        {
    //            prefab = existingPrefab;
    //        }

    //        if (prefab != null)
    //        {
    //            if (ParseModel(pokemonName, modelPath, out foundAnimations, out attackAnimHalfDuration, out laserSourcePath))
    //            {
    //                GameObject instance = (GameObject) Instantiate(prefab, Vector3.zero, Quaternion.identity);
    //                instance.transform.parent = SceneHelper.GetContainer(Container.Pokemons).transform;

    //                CreateAnimator(animatorPath, foundAnimations, prefab);
    //                AddControllerScript(prefab, laserSourcePath, attackAnimHalfDuration);

    //                CreateNavMeshAgent(prefab);
    //                CreateNetworkView(prefab);
    //                CreateCollider(prefab);

    //                //SavePrefab(prefab, modelPath);

    //                EditorApplication.SaveAssets();
                                            
    //                prefab.name = "_" + prefab.name; // We change the name of the prefab in case it can't be deleted, so it's easier to notice.
    //                DestroyImmediate(instance, false);
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// Creates the prefab.
    //    /// </summary>
    //    /// <returns><c>true</c>, if prefab was created, <c>false</c> otherwise.</returns>
    //    /// <param name="modelPath">Model path.</param>
    //    /// <param name="prefabPath">Prefab path.</param>
    //    /// <param name="pokemonName">Pokemon name.</param>
    //    /// <param name="prefab">Prefab to create.</param>
    //    private static bool CreatePrefab(string modelPath, string prefabPath, string pokemonName, out GameObject prefab)
    //    {
    //        // Creates the prefab from the Pokemon model file
    //        GameObject pokemonGameObject = Resources.LoadAssetAtPath<GameObject>(modelPath);
    //        PrefabUtility.CreatePrefab(prefabPath, pokemonGameObject);

    //        // Loads the created prefab and checks whether it was correctly loaded or not
    //        prefab = Resources.LoadAssetAtPath<GameObject>(prefabPath);

    //        if (prefab == null)
    //        {
    //            Debug.LogError(string.Format ("The creation of the prefab '{0}' has failed", pokemonName));
    //            return false;
    //        }

    //        return true;
    //    }

    //    /// <summary>
    //    /// Parses the model.
    //    /// </summary>
    //    /// <param name="pokemonName">Pokemon name.</param>
    //    /// <param name="modelPath">Model path.</param>
    //    /// <param name="animations">Animations.</param>
    //    /// <param name="attackAnimHalfDuration">Attack animation half duration.</param>
    //    /// <param name="laserSourcePath">Laser source path.</param>
    //    private static bool ParseModel(string pokemonName, string modelPath, out Dictionary<string, AnimationClip> animations, out Dictionary<MoveCategory, float> attackAnimHalfDuration, out string laserSourcePath)
    //    {
    //        Dictionary<MoveCategory, float> attackHalfDuration = new Dictionary<MoveCategory, float>();
    //        Dictionary<string, AnimationClip> foundAnimations = new Dictionary<string, AnimationClip>();
    //        bool isLoopMissing = false;
    //        bool isEventMissing = false;
    //        bool isLaserSourcePathMissing = true;
    //        string laserBoneSourcePath = LaserBoneName;

    //        object[] assetList = AssetDatabase.LoadAllAssetsAtPath(modelPath);
    //        List<string> animationsToFind = ModelAnimations.ToList();

    //        foreach (object asset in assetList)
    //        {
    //            AnimationClip animationClip = asset as AnimationClip;
    //            Transform transform = asset as Transform;

    //            if (animationClip != null && Array.IndexOf(ModelAnimations, animationClip.name) > -1) 
    //            {
    //                if (animationClip.name.EndsWith("Attack"))
    //                {
    //                    bool eventLaunchAttackIsPresent = false;
    //                    AnimationEvent[] animationEvents = AnimationUtility.GetAnimationEvents(animationClip);
    //                    MoveCategory move = ParseMove(animationClip.name);

    //                    foreach(AnimationEvent animationEvent in animationEvents)
    //                    {
    //                        if(animationEvent.functionName == LaunchAttackEventName)
    //                        {
    //                            attackHalfDuration.Add(move, animationClip.length - animationEvent.time);
    //                            eventLaunchAttackIsPresent = true;
    //                            break;
    //                        }
    //                    }
                        
    //                    if(!eventLaunchAttackIsPresent)
    //                    {
    //                        isEventMissing = true;
    //                        Debug.LogError(string.Format("Missing {0} event in the {1} animation of {2}.", LaunchAttackEventName, animationClip.name, pokemonName));

    //                        /*
    //                         * DOESN'T WORK !
    //                        AnimationEvent animationEvent = new AnimationEvent()
    //                        {
    //                            time = animationClip.length / 2,
    //                            functionName = LaunchAttackEventName
    //                        };
    //                        AnimationUtility.SetAnimationEvents(animationClip, new AnimationEvent[] { animationEvent });
    //                        attackHalfDuration.Add(move, animationClip.length / 2);
    //                        */

    //                        //missingAnimationEvent = true;
    //                        //Debug.LogWarning("Please add the LaunchAttack event to the animation " + resource.name + " of " + pokemonToInvoke + ".");
    //                    }
    //                }

    //                animationsToFind.Remove(animationClip.name);
    //                foundAnimations.Add(animationClip.name, animationClip);
    //            }
    //            else if (transform != null && transform.name == LaserBoneName)
    //            {
    //                if (transform.parent != null)
    //                {
    //                    Transform parent = transform.parent;

    //                    while(parent.name != "Armature")
    //                    {
    //                        laserBoneSourcePath = parent.name + "/" + laserBoneSourcePath;
    //                        parent = parent.parent;
    //                    }

    //                    isLaserSourcePathMissing = false;
    //                }
    //            }
    //        }

    //        /*
    //         * DOESNT WORK !
    //         * 
    //        if(foundAnimations.ContainsKey("Idle"))
    //        {
    //            foundAnimations["Idle"].wrapMode = WrapMode.Loop;
    //        }
            
    //        if(foundAnimations.ContainsKey("Run"))
    //        {
    //            foundAnimations["Run"].wrapMode = WrapMode.Loop;
    //        }


    //        if(foundAnimations.ContainsKey("SpecialAttack"))
    //        {
    //            AnimationClip anim = foundAnimations["SpecialAttack"];
    //            AnimationEvent ev = new AnimationEvent();
                
    //            ev.functionName = LaunchAttackEventName;
    //            ev.time = anim.length * 0.45f;
    //            AnimationUtility.SetAnimationEvents(anim, new AnimationEvent[] { ev });
    //        }
    //        */
            
    //        if (isLaserSourcePathMissing)
    //        {
    //            Debug.LogError(string.Format("Missing {0} bone for {1}.", LaserBoneName, pokemonName));
    //        }

    //        if (animationsToFind.Count > 0)
    //        {
    //            foreach (string animationMissing in animationsToFind)
    //            {
    //                Debug.LogError(string.Format ("Missing {0} animation for {1}.", animationMissing, pokemonName));
    //            }

    //            animations = null;
    //            attackAnimHalfDuration = null;
    //            laserSourcePath = null;
    //            return false;
    //        }
    //        else
    //        {
    //            if(!foundAnimations["Idle"].isLooping)
    //            {
    //                isLoopMissing = true;
    //                Debug.LogError(string.Format("The Idle animation of {0} is not looping. Please make it loop.", pokemonName));
    //            }
                
    //            if(!foundAnimations["Run"].isLooping)
    //            {
    //                isLoopMissing = true;
    //                Debug.LogError(string.Format("The Run animation of {0} is not looping. Please make it loop.", pokemonName));
    //            }
    //        }

    //        if (animationsToFind.Count == 0 && !isLoopMissing && !isEventMissing && !isLaserSourcePathMissing)
    //        {
    //            animations = foundAnimations;
    //            attackAnimHalfDuration = attackHalfDuration;
    //            laserSourcePath = laserBoneSourcePath;
    //            return true;
    //        }
    //        else
    //        {
    //            animations = null;
    //            attackAnimHalfDuration = null;
    //            laserSourcePath = null;
    //            return false;
    //        }
    //    }

    //    /// <summary>
    //    /// Creates the animator.
    //    /// </summary>
    //    /// <param name="animatorPath">Animator path.</param>
    //    /// <param name="animationsFound">Animations found.</param>
    //    /// <param name="prefab">Prefab.</param>
    //    private static void CreateAnimator(string animatorPath, Dictionary<string, AnimationClip> animationsFound, GameObject prefab)
    //    {
    //        if (Resources.LoadAssetAtPath<AnimatorController>(animatorPath) == null)
    //        {
    //            bool isCopySucceeded = AssetDatabase.CopyAsset(TemplateAnimatorPath, animatorPath);
    //            if (isCopySucceeded)
    //            {
    //                AssetDatabase.Refresh();

    //                AnimatorController animatorController = Resources.LoadAssetAtPath<AnimatorController>(animatorPath);
    //                StateMachine stateMachine = animatorController.GetLayer(0).stateMachine;

    //                for (int i = 0; i < animationsFound.Count; i++)
    //                {
    //                    State state = stateMachine.GetState(i);

    //                    if (state == null)
    //                    {
    //                        break;
    //                    }

    //                    state.SetAnimationClip(animationsFound[state.name]);
    //                }

    //                Animator animator = (Animator) prefab.GetComponent("Animator");
    //                if (!animator)
    //                {
    //                    animator = (Animator) prefab.AddComponent<Animator>();
    //                }

    //                animator.runtimeAnimatorController = animatorController;
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// Creates the nav mesh agent.
    //    /// </summary>
    //    /// <param name="prefab">Prefab.</param>
    //    private static void CreateNavMeshAgent(GameObject prefab)
    //    {
    //        NavMeshAgent navMeshAgent = prefab.GetComponent<NavMeshAgent>();
    //        if (!navMeshAgent)
    //        {
    //            navMeshAgent = (NavMeshAgent)prefab.AddComponent("NavMeshAgent");
            
    //            navMeshAgent.stoppingDistance = 0f;            
    //            navMeshAgent.speed = 5f;
    //            navMeshAgent.radius = 1f;
    //            navMeshAgent.height = 5f;
    //            navMeshAgent.acceleration = navMeshAgent.speed * 400f;
    //            navMeshAgent.angularSpeed = 0f;            
    //            navMeshAgent.autoBraking = false;
    //        }
    //    }

    //    /// <summary>
    //    /// Adds the controller script.
    //    /// </summary>
    //    /// <param name="prefab">Prefab.</param>
    //    /// <param name="laserSourcePath">Laser source path.</param>
    //    /// <param name="attackAnimHalfDuration">Attack animation half duration.</param>
    //    private static void AddControllerScript(GameObject prefab, string laserSourcePath, Dictionary<MoveCategory, float> attackAnimHalfDuration)
    //    {
    //        PokemonController script = (PokemonController)prefab.GetComponent("PokemonController");
    //        if (!script)
    //        {
    //            script = (PokemonController)prefab.AddComponent<PokemonController>();
    //        }
            
    //        script.laserSourcePath = laserSourcePath;
    //        script.attackAnimHalfDuration = attackAnimHalfDuration;
    //    }

    //    /// <summary>
    //    /// Creates the network view.
    //    /// </summary>
    //    /// <param name="prefab">Prefab.</param>
    //    private static void CreateNetworkView(GameObject prefab)
    //    {
    //        NetworkView view = (NetworkView)prefab.GetComponent(typeof(NetworkView));
    //        if (!view)
    //        {
    //            view = (NetworkView)prefab.AddComponent<NetworkView>();
    //        }
            
    //        view.stateSynchronization = NetworkStateSynchronization.Off;
    //    }

    //    /// <summary>
    //    /// Creates the collider.
    //    /// </summary>
    //    /// <param name="prefab">Prefab.</param>
    //    private static void CreateCollider(GameObject prefab)
    //    {       
    //        if((Collider)prefab.GetComponent(typeof(Collider)) != null)
    //            return;
            
    //        SphereCollider sphereCollider = (SphereCollider)prefab.AddComponent<SphereCollider>();
    //        sphereCollider.radius = 1f;
    //        sphereCollider.center = new Vector3(0f, 1f, 0f);
    //    }

    //    /// <summary>
    //    /// Saves the prefab.
    //    /// </summary>
    //    /// <param name="prefab">Prefab.</param>
    //    /// <param name="modelPath">Model path.</param>
    //    private static void SavePrefab(GameObject prefab, string modelPath)
    //    {
    //        PrefabUtility.ReplacePrefab(prefab, Resources.LoadAssetAtPath<GameObject>(modelPath));
    //    }

    //    /// <summary>
    //    /// Parses the move.
    //    /// </summary>
    //    /// <returns>The move.</returns>
    //    /// <param name="animationName">Animation name.</param>
    //    private static MoveCategory ParseMove(string animationName)
    //    {
    //        switch(animationName)
    //        {
    //        case "PhysicalAttack":
    //            return MoveCategory.Physical;
                
    //        case "SpecialAttack":
    //            return MoveCategory.Special;
                
    //        case "StatusAttack":
    //            return MoveCategory.Status;
                
    //        default:
    //            return MoveCategory.ERROR;
    //        }
    //    }
    //}
}
