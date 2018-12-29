using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossExample : MonoBehaviour {

	Vector3 GetNormal(Vector3 a,Vector3 b,Vector3 c){
		Vector3 side1 = b- a;
		Vector3 side2 = c- a;

		return Vector3.Cross(side1, side2).normalized;
	}
}
