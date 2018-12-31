using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

		Fruit myFruit = new Apple();

		myFruit.SayHello();
		myFruit.Chop();

		Apple myApple = (Apple)myFruit;

		myApple.SayHello();
		myApple.Chop();
	}
	
}
