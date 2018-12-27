using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour {

	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			GetComponent<MeshRenderer>().material.color = Color.red;
		} else if(Input.GetKeyDown(KeyCode.G)){
			GetComponent<MeshRenderer>().material.color = Color.green;
		} else if(Input.GetKeyDown(KeyCode.B)){
			GetComponent<MeshRenderer>().material.color = Color.blue;
		}
	}
}
