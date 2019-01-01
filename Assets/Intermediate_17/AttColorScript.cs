using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AttColorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer>().sharedMaterial.color = Color.blue;
	}
	
}
