using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleInterpolation : MonoBehaviour {

	public Light light;

	// Use this for initialization
	void Start () {

		float result;

		result = Mathf.Lerp(3f, 5f, 0.5f);
		Debug.Log("Between 3 an 5, with 0.5, is " + result);

		Vector3 from = new Vector3 (1f, 2f, 3f);
		Vector3 to = new Vector3(5f,6f,7f);

		Vector3 vectorResult = Vector3.Lerp(from, to, 0.75f);
		Debug.Log("About Vectors, Between 1,2,3 & 5,6,7 , with 0.75, is : "+ vectorResult);




		
	}
	
	// Update is called once per frame
	void Update () {
		light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
	}
}
