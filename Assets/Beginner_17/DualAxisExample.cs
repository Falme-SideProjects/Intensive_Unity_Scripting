using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour {

	public float range;
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		float xPos = h*range;
		float yPos = v*range;

		Debug.Log("Horizontal Value Returned: "+h.ToString("F2"));
		Debug.Log("Vertical Value Returned: "+v.ToString("F2"));
	}
}
