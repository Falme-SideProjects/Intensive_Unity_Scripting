using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		IntermPlayer myPlayer = new IntermPlayer();

		myPlayer.Experience = 5;
		int x = myPlayer.Experience;
		Debug.Log(x);

	}
	
}
