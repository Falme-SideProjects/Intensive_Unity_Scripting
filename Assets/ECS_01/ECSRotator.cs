using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class ECSRotator : MonoBehaviour {

	public float speed;
}

/* public class ECSRotatorSystem : ComponentSystem
{
	struct Components
	{
		public ECSRotator rotator;
		public Transform transform;
	}

	protected override void OnUpdate(){

	}
} */

class ECSRotatorSystem : ComponentSystem
{
	float deltaTime = Time.deltaTime;

	struct Components
	{
		public ECSRotator rotator;
		public Transform transform;
	}

	protected override void OnUpdate()
	{
		foreach(var e in GetEntities<Components>())
		{
			e.transform.Rotate(0f, e.rotator.speed * deltaTime, 1f);
		}
	}
}