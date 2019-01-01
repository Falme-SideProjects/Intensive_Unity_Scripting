using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttSpinScript : MonoBehaviour {

	[Range(-100,100)] public int speed = 0;

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
	}
}
