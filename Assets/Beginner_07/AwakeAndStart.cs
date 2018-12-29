using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Start Called");
	}
	
	void Awake(){
		Debug.Log("Awake Called");
	}
}
