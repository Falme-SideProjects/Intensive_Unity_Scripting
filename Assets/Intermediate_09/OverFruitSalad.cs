using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverFruitSalad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		OverApple myApple = new OverApple();

		myApple.SayHello();
		myApple.Chop();

		OverFruit myFruit = new OverApple();
		myFruit.SayHello();
		myFruit.Chop();
	}
	
}
