using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemberEnemy : Humanoid {

	new public void Yell(){
		Debug.Log("Enemy version of the Yell() method");
	}
}
