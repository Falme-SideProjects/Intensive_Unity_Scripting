using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictSomeOtherClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Dictionary<string, DictBadGuy> badguys = new Dictionary<string, DictBadGuy>();

		DictBadGuy bg1 = new DictBadGuy("Harvey", 50);
		DictBadGuy bg2 = new DictBadGuy("Magneto", 100);

		badguys.Add("gangster", bg1);
		badguys.Add("mutant", bg2);

		DictBadGuy magneto = badguys["mutant"];

		DictBadGuy temp = null;


		if(badguys.TryGetValue("birds", out temp)){

		} else {
			
		}


	}
	
}
