using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass {

	public string color;

	// Use this for initialization
	public FruitClass() {
		color = "orange";
		Debug.Log("1st Fruit Constructor Called");
	}

	public FruitClass(string newColor){
		color = newColor;
		Debug.Log("2nd constructor called");
	}

	public void Chop(){
		Debug.Log("The "+color+"fruit has been chopped");
	}
	
	// Update is called once per frame
	public void SayHello () {
		Debug.Log("Hello, I am a fruit");
	}
}
