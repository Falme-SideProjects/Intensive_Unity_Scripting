using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

	void OnMouseDown()
	{
		Rigidbody _rb = GetComponent<Rigidbody>();
		_rb.AddForce(-transform.forward);
		_rb.useGravity = true;
	}
}
