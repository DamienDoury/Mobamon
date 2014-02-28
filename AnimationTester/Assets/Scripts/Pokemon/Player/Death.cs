using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{
	private Mesh mesh = null;
	private Animator anim = null;
	private GameObject skel = null;

	private float desiredScale = 1f;

	void Update()
	{
		float scale = gameObject.transform.localScale.x;

		if(scale != desiredScale)
		{
			/*float newScale
			gameObject.transform.localScale.x = */
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			DeformMesh();
		}
	}

	void GetMesh()
	{
		if(mesh == null)
		{
			SkinnedMeshRenderer rend = (SkinnedMeshRenderer)gameObject.GetComponentInChildren(typeof(SkinnedMeshRenderer));
			anim = gameObject.GetComponent<Animator>();
			skel = gameObject.transform.Find("Armature").gameObject;
			mesh = rend.sharedMesh;
		}
	}

	void DeformMesh()
	{
		GetMesh();

		if(mesh == null)
			return;

		anim.enabled = false;

		Vector3 vanishingPoint = gameObject.transform.position;
		Vector3[] vertices = mesh.vertices;
		int i = 0;

		/*Transform[] bonesList = skel.GetComponentsInChildren<Transform>();
		foreach(Transform bone in bonesList)
		{
			if(bone.name.Equals("Armature"))
				continue;
			Vector3 pos = (bone.position - transform.position) * 0.500f;
			bone.position = pos + transform.position;
			//break;
		}*/

		while (i < vertices.Length)
		{
			Vector3 vect = vertices[i];
			Vector3 vertMove = new Vector3(Random.Range(-2f, 2f), 0, Random.Range(-1f, 1f));
			vertices[i] = new Vector3(0, vect.y, vect.z);
			i++;
		}

		if(Application.platform != RuntimePlatform.WindowsEditor)
		{
			mesh.vertices = vertices;
			mesh.RecalculateBounds();
		}
	}
}