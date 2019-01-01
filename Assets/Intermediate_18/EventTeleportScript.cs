using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTeleportScript : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		EventManager.OnClicked += Teleport;
	}
	
	// Update is called once per frame
	void OnDisable () {
		EventManager.OnClicked -= Teleport;
	}

	void Teleport(){
		Vector3 pos = transform.position;
		pos.y = Random.Range(1.0f,3.0f);
		transform.position = pos;
	}
}
