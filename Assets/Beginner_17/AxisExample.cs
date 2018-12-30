using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisExample : MonoBehaviour {

	public float range;

	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float xPos = h*range;
		transform.position = new Vector3(xPos, 2f,0f);
		Debug.Log("Value Returned:" + h.ToString("F2"));
	}
}
