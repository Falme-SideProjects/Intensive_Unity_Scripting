using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotExample : MonoBehaviour {

	public Transform other;

	// Update is called once per frame
	void Update () {
		if(other){
			Vector3 forwaerd = transform.TransformDirection(Vector3.forward);
			Vector3 toOther = other.position - transform.position;

			if(Vector3.Dot(forwaerd, toOther) < 0){
				print("The other transform is behind me!!");
			}
		}
	}
}
