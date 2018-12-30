using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour {

	public GameObject otherGameObject;


	private ComponentAnotherScript anotherScript;
	private YetAnotherScript yetAnotherScript;
	private BoxCollider boxCol;


	void Awake(){
		anotherScript = GetComponent<ComponentAnotherScript>();
		yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
		boxCol = otherGameObject.GetComponent<BoxCollider>();
	}

	// Use this for initialization
	void Start () {
		boxCol.size = new Vector3(3,3,3);
		Debug.Log("The player's Score is "+anotherScript.playerScore);
		Debug.Log("The player has died "+yetAnotherScript.numberOfPlayerDeaths + " times");
	}
	
}
