using UnityEngine;
using System.Collections;

public class SelectedMove
{
	public string name;
	public MoveInfo info;
	public Target target;
	public bool isDone;

	public SelectedMove(string _name)
	{
		name = _name;

		target = null;
		info = Attackdex.move[name];
		isDone = false;
	}

	public void SetTarget(Target _target)
	{
		target = _target;
	}

	public bool IsLaunched()
	{
		return (target != null);// && isDone == false);
	}
}
