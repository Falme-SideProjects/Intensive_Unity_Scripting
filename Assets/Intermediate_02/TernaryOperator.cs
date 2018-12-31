using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int health = 10;
		string message;

		message = health > 0 ? "Player is Alive!!":"Player is Dead";
	}
	
}
