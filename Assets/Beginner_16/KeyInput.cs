using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

	public GUITexture graphics;
	public Texture2D standard;
	public Texture2D downgfx;
	public Texture2D upgfx;
	public Texture2D heldgfx;


	// Use this for initialization
	void Start () {
		graphics.texture = standard;
	}
	
	// Update is called once per frame
	void Update () {
		bool down = Input.GetKeyDown(KeyCode.Space);
		bool held = Input.GetKey(KeyCode.Space);
		bool up = Input.GetKeyUp(KeyCode.Space);

		if(down){
			graphics.texture = downgfx;
		}
		else if(held){
			graphics.texture = heldgfx;
		}
		else if(up){
			graphics.texture = upgfx;
		}
		else{
			graphics.texture = standard;
		}

		Debug.Log(" "+down+ "\n" + held + "\n" + up);

	}
}
