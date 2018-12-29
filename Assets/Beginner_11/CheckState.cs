using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour {

	public GameObject myObject;

	// Use this for initialization
	void Start () {
		Debug.Log("Active Self: "+myObject.activeSelf);
		Debug.Log("Active in Hierarchy: "+myObject.activeInHierarchy);
	}
	
}
