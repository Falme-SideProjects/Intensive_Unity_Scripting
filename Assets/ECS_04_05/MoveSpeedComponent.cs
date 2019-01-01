using System;
using Unity.Entities;

namespace ECS_04
{
	[Serializable]
	public struct MoveSpeed : IComponentData
	{
		public float Value;
	}

	public class MoveSpeedComponent : ComponentDataWrapper<MoveSpeed> { }

}