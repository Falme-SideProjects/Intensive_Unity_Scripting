using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

	public float coffeeTemperature = 85.0f;
	public float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		coffeeTemperature -= Time.deltaTime;
	}

	void TemperatureTest(){

		// If the coffe temperature is greater than 70
		if(coffeeTemperature > hotLimitTemperature){
			print("Coffee is too hot!");
		}
		else if(coffeeTemperature < coldLimitTemperature){
			print("Coffee is too cold");
		}
		else {
			print(" Coffee is just right");
		}

	}
}
