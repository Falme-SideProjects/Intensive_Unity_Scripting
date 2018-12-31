using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		Invoke("SpawnObject", 2);
	}
	
	// Update is called once per frame
	void SpawnObject() {
		Instantiate(target, new Vector3(0,2,0), Quaternion.identity);
	}
}
