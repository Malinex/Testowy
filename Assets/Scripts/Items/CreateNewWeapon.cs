using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour
{
	private BaseWeapon newWeapon;
	private string[] itemDes = new string[4] { "A new good wapon", "Warrior's wapon", "Mage's wapon", "Hunter's wapon" };
	private void CreateWeapon()
	{
		newWeapon = new BaseWeapon();
		newWeapon.ItemName = "W" + Random.Range(1, 101);
		newWeapon.ItemDescription = itemDes[Random.Range(0, itemDes.Length)];
		//Name and Description
		newWeapon.ItemID = Random.Range(1, 101);
		//ID
		newWeapon.Stamina = Random.Range(1, 11);
		newWeapon.Agility = Random.Range(1, 11);
		newWeapon.Stength = Random.Range(1, 11);
		newWeapon.Intellect = Random.Range(1, 11);
		newWeapon.Endurance = Random.Range(1, 11);
		//Weapon Stats
		ChooseWeaponType();
		//choosing Wapon Type - method
		newWeapon.SpellEffectID= Random.Range(1, 101);
	}
	private void ChooseWeaponType()
	{
		int randomTemp = Random.Range(1, 7);
		if (randomTemp == 1) { newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD; }
		else if (randomTemp == 2) { newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD; }
		else if (randomTemp == 3) { newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF; }
		else if (randomTemp == 4) { newWeapon.WeaponType = BaseWeapon.WeaponTypes.WAND; }
		else if (randomTemp == 5) { newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW; }
		else if (randomTemp == 6) { newWeapon.WeaponType = BaseWeapon.WeaponTypes.GUN; }

	}
	void Start()
	{
		CreateWeapon();
		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.ItemID.ToString());
		Debug.Log(newWeapon.WeaponType.ToString());
		Debug.Log(newWeapon.Stamina.ToString());
		Debug.Log(newWeapon.Agility.ToString());
		Debug.Log(newWeapon.Stength.ToString());
		Debug.Log(newWeapon.Intellect.ToString());
		Debug.Log(newWeapon.Endurance.ToString());
	}
}
