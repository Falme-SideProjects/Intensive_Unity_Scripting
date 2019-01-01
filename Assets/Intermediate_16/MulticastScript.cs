using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour {

	delegate void MultiDelegate();
	MultiDelegate myMultiDelegate;

	// Use this for initialization
	void Start () 
	{
		myMultiDelegate += PowerUp;
		myMultiDelegate += TurnRed;

		if(myMultiDelegate != null){
			myMultiDelegate();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PowerUp()
	{
		print("Orb is powering up");
	}

	void TurnRed(){
		GetComponent<MeshRenderer>().material.color = Color.red;
	}
}
