using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverApple : OverFruit {

	public OverApple(){
		Debug.Log("1st Apple constructor called");
	}

	public override void Chop(){
		base.Chop();
		Debug.Log("The Apple has been chopped");
	}

	public override void SayHello(){
		base.SayHello();
		Debug.Log("Hello I'm an apple");
	}
}
