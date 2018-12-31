using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermPlayer {

	private int experience;

	public int Experience{
		get{
			return this.experience;
		}
		set{
			experience = value;
		}
	}

	public int Level
	{
		get{
			return experience/1000;
		}
		set{
			experience = value * 1000;
		}
	}

	public int Health{get; set;}

}
