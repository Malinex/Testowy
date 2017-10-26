using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem
{
	private int stamina;
	private int stength;
	private int intellect;
	private int agility;
	private int endurance;

	public int Stamina
	{
		get { return stamina; }
		set { stamina = value; }
	}
	public int Stength
	{
		get { return stength; }
		set { stength = value; }
	}
	public int Intellect
	{
		get { return intellect; }
		set { intellect = value; }
	}
	public int Agility
	{
		get { return agility; }
		set { agility = value; }
	}
	public int Endurance
	{
		get { return endurance; }
		set { endurance = value; }
	}
}
