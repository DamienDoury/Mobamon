using UnityEngine;

namespace Mobamon.Moves
{
	public class MoveTrigger : MonoBehaviour
	{
		public void OnTriggerEnter(Collider collider)
		{
			GameObject parentObject = this.transform.parent.gameObject;

			if (parentObject != null) 
			{
				Move move = parentObject.GetComponent<Move>();

				if (move != null)
				{
					move.RegisterCollider(collider);
				}
			}
		}
	}
}

