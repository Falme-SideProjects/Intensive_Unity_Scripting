using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit {

	public Fruit(){
		Debug.Log("1st fruit constructor called");
	}

	public void Chop(){
		Debug.Log("The fruit has been chopped");
	}

	public void SayHello(){
		Debug.Log("Hello, I'm a Fruit");
	}
}
