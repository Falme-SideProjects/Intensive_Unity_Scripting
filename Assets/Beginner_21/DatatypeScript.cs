using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Vector3 pos = transform.position;
		pos = new Vector3(0, 2, 0);	

		Debug.Log(transform.position);

		Transform tran = transform;
		tran.position = new Vector3(0,2,0);

		Debug.Log(transform.position);
		

	}
	
}
