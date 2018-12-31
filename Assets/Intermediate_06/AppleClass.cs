using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleClass : FruitClass {

	// Use this for initialization
	public AppleClass () {
		color = "red";
		Debug.Log("1st Apple constructor called");
	}

	public AppleClass(string newColor) : base(newColor){
		Debug.Log("2nd Apple Costructor Called");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
