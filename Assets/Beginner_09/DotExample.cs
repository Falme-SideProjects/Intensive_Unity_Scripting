using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotExample : MonoBehaviour {

	public Transform other;
	public Transform andAnotherOther;

	void Start(){
		CrossExample _cx = new CrossExample();
		Debug.Log(_cx.GetNormal(transform.position, other.position, andAnotherOther.position));
	}

	// Update is called once per frame
	void Update () {
		if(other){
			Vector3 forwaerd = transform.TransformDirection(Vector3.forward);
			Vector3 toOther = other.position - transform.position;

			Debug.Log(Vector3.Dot(forwaerd, toOther));

			if(Vector3.Dot(forwaerd, toOther) < 0){
				print("The other transform is behind me!!");
			}
		}
	}
}
