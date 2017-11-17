using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem
{
	public enum WeaponTypes
	{
		SWORD,
		SHIELD,
		STAFF,
		WAND,
		BOW,
		GUN
	}
	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType{get { return weaponType; }set { weaponType = value; }}
	public int SpellEffectID{get { return spellEffectID; }set { spellEffectID = value; }}

}