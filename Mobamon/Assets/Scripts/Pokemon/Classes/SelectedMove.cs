using UnityEngine;
using System.Collections;
using Mobamon.Database;
using Mobamon.Database.Classes;

namespace Mobamon.Pokemon.Classes
{
	public class SelectedMove
	{
		public string name;
		public MoveInfo info;
		public MoveTarget target;
		public bool isDone;

		public SelectedMove(string _name)
		{
			name = _name;

			target = null;
			info = Attackdex.move[name];
			isDone = false;
		}

		public void SetTarget(MoveTarget _target)
		{
			target = _target;
		}

		public bool IsLaunched()
		{
			return (target != null);// && isDone == false);
		}
	}
}