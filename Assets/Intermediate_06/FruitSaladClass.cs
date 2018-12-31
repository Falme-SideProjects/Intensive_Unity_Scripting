using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Creating the fruit");
		FruitClass myFruit = new FruitClass();
		Debug.Log("Creating new Apple");
		AppleClass myApple = new AppleClass();


		myFruit.SayHello();
		myApple.Chop();

		myApple.SayHello();
		myFruit.Chop();


		Debug.Log("Creating the fruit");
		myFruit = new FruitClass("yellow");
		Debug.Log("Creating the apple");
		myApple = new AppleClass("green");

		

		myFruit.SayHello();
		myApple.Chop();

		myApple.SayHello();
		myFruit.Chop();
	}
	
}
