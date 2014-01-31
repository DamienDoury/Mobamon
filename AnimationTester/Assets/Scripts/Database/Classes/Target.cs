using UnityEngine;

namespace Mobamon.Database.Classes
{
	public class Target
	{
		public GameObject obj;
		public Vector3 pos;
		
		public Target(GameObject p_obj, Vector3 p_pos)
		{
			obj = p_obj;
			pos = p_pos;
		}
	}
}