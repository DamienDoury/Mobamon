using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {

	public int speed;
	public int specialAttack;
	public int physicalAttack;

	void Awake() {
		speed = Animator.StringToHash("Speed");
		specialAttack = Animator.StringToHash("SpecialAttack");
		physicalAttack = Animator.StringToHash("PhysicalAttack");
	}
}
