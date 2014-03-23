using UnityEngine;
using System.Collections;
using Mobamon.Database;
using Mobamon.Database.Enums;

public class Celshading : MonoBehaviour
{
    private int shadingMode;
	private int initialShadingMode = 3;
    private int newMode;

	private Transform entitiesList;
	private Terrain terrain;
	private Renderer treeRenderer;
	private GameObject marker;

	private Shader shaderNormal;
	private Shader shaderToon;

	public Texture smoothToonRampTexture;
	public Texture sharpToonRampTexture;

	public Material smoothToonMaterial;
	public Material sharpToonMaterial;

    public static Celshading instance;
	
	private void Start()
	{
        instance = this;

        entitiesList = SceneHelper.GetContainer(Container.Entities).transform;

		GameObject terrainObj = GameObject.Find("Map");
		terrain = (Terrain)terrainObj.GetComponent(typeof(Terrain));
		treeRenderer = terrain.terrainData.treePrototypes[0].prefab.renderer;

		shaderNormal = Shader.Find("Diffuse");
		shaderToon = Shader.Find("Toon/Lighted Outline");

        shadingMode = initialShadingMode;
        newMode = shadingMode;
		ApplyShadingMode();
	}
	
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.F1))
			newMode = 1;
		else if(Input.GetKeyDown(KeyCode.F2))
            newMode = 2;
		else if(Input.GetKeyDown(KeyCode.F3))
            newMode = 3;

        if(newMode != shadingMode)
        {
            shadingMode = newMode;
            ApplyShadingMode();
        }
	}

	public void ApplyShadingMode()
	{
		// Securities.
		if(Application.platform == RuntimePlatform.WindowsEditor)
			return;            	

		// First of all, we select the shader, ramp textures and the material.
		Shader shader = new Shader();
		Texture ramp = new Texture();
		Material material = new Material(shaderNormal);
		
        if(shadingMode == 1) // No cell shading.
		{
			shader = shaderNormal;
			ramp = null;
			material = null;
		}
        else if(shadingMode == 2) // Outline only.
		{
			shader = shaderToon;
			ramp = smoothToonRampTexture;
			material = smoothToonMaterial;
		}
        else if(shadingMode == 3) // Full cell shading : outline and lights.
		{
			shader = shaderToon;
			ramp = sharpToonRampTexture;
			material = sharpToonMaterial;
		}

		// Then, we apply it to the pokemons, trees and ground.
        SkinnedMeshRenderer[] rendList = entitiesList.gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach(SkinnedMeshRenderer rend in rendList)
		{
			//MeshRenderer rend = (MeshRenderer)pkmn.gameObject.GetComponentInChildren(typeof(MeshRenderer));

			foreach(Material mat in rend.materials)
			{
				mat.shader = shader;

                if(shadingMode > 1)
                {
                    mat.SetTexture("_Ramp", ramp);
                    mat.SetFloat("_Outline", 0.002f);
                }
			}
		}

		foreach(Material treeMat in treeRenderer.materials)
		{
			treeMat.shader = shader;

            if(shadingMode > 1)
            {
                treeMat.SetTexture("_Ramp", ramp);
                treeMat.SetFloat("_Outline", 0.002f);
            }
		}

		terrain.materialTemplate = material;

		/*marker = GameObject.FindWithTag("Marker");
		if(marker != null)
		{
			Renderer rend = (Renderer)marker.GetComponentInChildren(typeof(Renderer));
			rend.material.shader = shader;
		}*/

		// Finally, we refresh the map so the changes are accounted.
 		terrain.terrainData.RefreshPrototypes();
		terrain.Flush();
	}
}
