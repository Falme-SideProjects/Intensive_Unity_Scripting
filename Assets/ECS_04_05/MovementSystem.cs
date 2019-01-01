﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Jobs;

namespace ECS_04
{

	public class MovementSystem : JobComponentSystem {

		[ComputeJobOptimization]
		struct MovementJob : IJobProcessComponentData<Position, Rotation, MoveSpeed>
		{
			public float topBound;
			public float bottomBound;
			public float deltaTime;

			public void Execute(ref Position position, [ReadOnly] ref Rotation rotation, [ReadOnly] ref MoveSpeed speed)
			{
				float3 value = position.Value;

				value += deltaTime * speed.Value * math.forward(rotation.Value);

				if(value.z < bottomBound)
					value.z = topBound;

				position.Value = value;
			}

		}
		
		protected override JobHandle OnUpdate(JobHandle inputDeps)
		{
			MovementJob moveJob = new MovementJob
			{
				topBound = GameManager.GM.topBound,
				bottomBound = GameManager.GM.bottomBound,
				deltaTime = Time.deltaTime
			};

			JobHandle moveHandle = moveJob.Schedule(this, 64, inputDeps);

			return moveHandle;
		}
		
	}

}