using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnObject", 2, 1);
	}
	
	// Update is called once per frame
	void SpawnObject () {
		float x = Random.Range(-2.0f, 2.0f);
		float z = Random.Range(-2.0f, 2.0f);
		Instantiate(target, new Vector3(x,2,z), Quaternion.identity);
	}
}
