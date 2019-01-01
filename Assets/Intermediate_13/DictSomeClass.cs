using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictSomeClass : MonoBehaviour {

	// Use this for initialization
	void Start () {

		List<DictBadGuy> badguys = new List<DictBadGuy>();

		badguys.Add(new DictBadGuy("Harvey", 50));
		badguys.Add(new DictBadGuy("Magneto", 100));
		badguys.Add(new DictBadGuy("Pip", 5));

		badguys.Sort();

		foreach(DictBadGuy guy in badguys){
			print(guy.name + " : " + guy.power);
		}

		badguys.Clear();

	}
	
}
