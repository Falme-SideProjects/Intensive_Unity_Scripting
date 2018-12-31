using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticUtilitiesExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int x = StaticUtilities.Add(5,6);
		Debug.Log(x);
	}
}
