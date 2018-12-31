using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverloadSomeOtherClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		OverloadSomeClass myClass = new OverloadSomeClass();

		myClass.Add(1,2);
		myClass.Add("Hello", "World");
	}
	
}
