using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GESomeOtherClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GESomeClass myClass = new GESomeClass();

		myClass.GenericMethod<int>(5);
		myClass.GenericMethod<GenericClass<int>>(new GenericClass<int>());
	}
	
}
