using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScroll : BaseStatItem
{
	public enum ScrollTypes
	{
		AGILITY,
		INTELLECT,
		STRENGTH,
		STAMINA,
		PROTECTION
	}
	private ScrollTypes scrollType;
	private int spellEffectID;

	public ScrollTypes WeaponType
	{
		get { return scrollType; }
		set { scrollType = value; }
	}
	public int SpellEffectID
	{
		get { return spellEffectID; }
		set { spellEffectID = value; }
	}

}