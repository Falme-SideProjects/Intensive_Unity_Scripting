using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour {

	delegate void MyDelegate(int num);
	MyDelegate myDelegate;


	// Use this for initialization
	void Start () {
		myDelegate = PrintNum;
		myDelegate(50);

		myDelegate = DoubleNum;
		myDelegate(12);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PrintNum(int num){
		print("Print Num: "+ num);
	}

	void DoubleNum(int num){
		print("Double Num: "+ num*2);
	}
}
