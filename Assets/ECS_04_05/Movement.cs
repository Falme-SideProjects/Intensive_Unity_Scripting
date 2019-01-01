using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ECS_04
{
	public class Movement : MonoBehaviour {

	
		// Update is called once per frame
		void Update () {
			Vector3 pos = transform.position;
			pos += transform.forward * GameManager.GM.enemySpeed * Time.deltaTime;

			if(pos.z < GameManager.GM.bottomBound)
				pos.z = GameManager.GM.topBound;

			transform.position = pos;
		}
	}

}