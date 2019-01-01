using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DictBadGuy : IComparable<DictBadGuy> {

	public string name;
	public int power;

	public DictBadGuy(string newName, int newPower){
		name = newName;
		power = newPower;
	}

    public int CompareTo(DictBadGuy other)
    {
        if(other == null)
		{
			return 1;
		}

		return power - other.power;
    }
}
