using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using UnityEditorInternal;
using UnityEngineInternal;
using System;

namespace Mobamon.Editor
{
    public class MobamonBuild : MonoBehaviour
    {
    	[MenuItem("Build/Server/Windows")]
    	public static void BuildWindowsServer()
    	{
    		string[] levels = {
    			"Assets/Scenes/Menus/StartScene.unity"
    		};
    		string defaultName = "Mobamon_server";
    		string preprocessorDefine = "SERVER";
    		BuildTarget buildTarget = BuildTarget.StandaloneWindows;
    		BuildOptions buildOptions = BuildOptions.Development;

    		MobamonBuild.Build(levels, defaultName, preprocessorDefine, buildTarget, buildOptions);
    	}

    	[MenuItem("Build/Client/Windows")]
    	public static void BuildWindowsClient()
    	{
    		string[] levels = {
    			"Assets/Scenes/Menus/StartScene.unity",
    			"Assets/Scenes/Menus/MainMenuScene.unity"
    		};
    		string defaultName = "Mobamon";
    		string preprocessorDefine = "CLIENT";
    		BuildTarget buildTarget = BuildTarget.StandaloneWindows;
    		BuildOptions buildOptions = BuildOptions.Development;
    		
    		MobamonBuild.Build(levels, defaultName, preprocessorDefine, buildTarget, buildOptions);
    	}

    	private static void Build(string[] levels, string defaultName, string preprocessorDefine, BuildTarget buildTarget, BuildOptions buildOptions)
    	{
    		// Get filename.
    		string path = EditorUtility.SaveFolderPanel("Choose location of the build", "", defaultName);

    		if (!string.IsNullOrEmpty(path))
    		{
    			// Define the preprocessor instruction
    			string previousDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
    			PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, "DEBUG;" + preprocessorDefine);
    			
    			// Build player.
    			BuildPipeline.BuildPlayer(levels, path + "/" + defaultName + ".exe", buildTarget, buildOptions);

    			// Revert preprocessor instruction
    			PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, previousDefines);
    		}
    	}
    }
}