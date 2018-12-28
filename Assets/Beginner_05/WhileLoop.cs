using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {

	int numberOfCups = 4;


	void Start () {
		while(numberOfCups > 0){
			Debug.Log("I've washed a cup");
			numberOfCups--;
		}
	}
	
}
