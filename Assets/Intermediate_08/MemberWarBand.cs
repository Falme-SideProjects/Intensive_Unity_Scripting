using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemberWarBand : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Humanoid human = new Humanoid();
		Humanoid enemy = new MemberEnemy();
		Humanoid orc = new MemberOrc();


		human.Yell();
		enemy.Yell();
		orc.Yell();

		
		Humanoid human2 = new Humanoid();
		MemberEnemy enemy2 = new MemberEnemy();
		MemberOrc orc2 = new MemberOrc();

		

		human2.Yell();
		enemy2.Yell();
		orc2.Yell();
	}
	
}
