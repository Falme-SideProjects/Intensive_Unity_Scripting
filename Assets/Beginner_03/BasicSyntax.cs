using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//This line is there to tell me the X position

		/*Hit There
		 *this is two lines
		 *
		 *
		 */

		Debug.Log(transform.position.x);

		if(transform.position.y <= 5f){
			Debug.Log("I'm about to hit the ground");
		}	
	}
	
}
