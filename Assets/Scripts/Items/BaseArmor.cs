using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArmor : BaseStatItem
{
	public enum ArmorTypes
	{
		HEAD,
		CHEST,
		LEGS,
		FEET,
		SHOULDERS,
		HANDS,
		WRISTS,
		MISC
	}
	private ArmorTypes armorType;
	private int spellEffectID;

	public ArmorTypes ArmorType	{get { return armorType; }set { armorType = value; }}
	public int SpellEffectID{get { return spellEffectID; }set { spellEffectID = value; }}

}