using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticGame {

	// Use this for initialization
	void Start () {
		StaticEnemy enemy1 = new StaticEnemy();
		StaticEnemy enemy2 = new StaticEnemy();
		StaticEnemy enemy3 = new StaticEnemy();


		int x = StaticEnemy.enemyCount;
		Debug.Log(x);
	}
	
}
