using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPlayerManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int x = StaticPlayer.playerCount;
		Debug.Log(x);
	}
	
}
