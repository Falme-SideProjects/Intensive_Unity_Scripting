using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GenericClass<int> myClass = new GenericClass<int>();
		myClass.UpdateItem(5);

	}
}
