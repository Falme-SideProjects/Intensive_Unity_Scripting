using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTurnColorScript : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		EventManager.OnClicked+=TurnColor;
	}
	
	// Update is called once per frame
	void OnDisable () {
		EventManager.OnClicked-=TurnColor;
	}

	void TurnColor(){
		Color col = new Color(Random.value, Random.value, Random.value);
		GetComponent<MeshRenderer>().material.color = col; 
	}
}
