using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewArmor : MonoBehaviour
{
	private BaseArmor newArmor;
	private string[] itemNames = new string[4] { "common", "uncommon", "rare", "epic" };
	private string[] itemDes = new string[4] { "A new good item", "Warrior's item", "Mage's item", "Hunter's item" };

	public void CreateArmor()
	{
		newArmor = new BaseArmor();
		newArmor.ItemName = itemNames[Random.Range(0, itemNames.Length)] + "Item";
		newArmor.ItemID = Random.Range(1, 101);
		//ID
		newArmor.ItemDescription = itemDes[Random.Range(0, itemDes.Length)];
		newArmor.Stamina = Random.Range(1, 11);
		newArmor.Agility = Random.Range(1, 11);
		newArmor.Stength = Random.Range(1, 11);
		newArmor.Intellect = Random.Range(1, 11);
		newArmor.Endurance = Random.Range(1, 11);
		//Armor Stats
		ChooseItemType();
		//choosing Armor Type - method
		newArmor.SpellEffectID= Random.Range(1, 101);
	}
	private void ChooseItemType()
	{
		int randomTemp = Random.Range(1, 9);
		newArmor.ArmorType = (BaseArmor.ArmorTypes)randomTemp - 1;
		/*if (randomTemp == 1) { newArmor.ArmorType = BaseArmor.ArmorTypes.HEAD; }
		else if (randomTemp == 2) { newArmor.ArmorType = BaseArmor.ArmorTypes.CHEST; }
		else if (randomTemp == 3) { newArmor.ArmorType = BaseArmor.ArmorTypes.LEGS; }
		else if (randomTemp == 4) { newArmor.ArmorType = BaseArmor.ArmorTypes.FEET; }
		else if (randomTemp == 5) { newArmor.ArmorType = BaseArmor.ArmorTypes.SHOULDERS; }
		else if (randomTemp == 6) { newArmor.ArmorType = BaseArmor.ArmorTypes.HANDS; }
		else if (randomTemp == 7) { newArmor.ArmorType = BaseArmor.ArmorTypes.WRISTS; }
		else if (randomTemp == 8) { newArmor.ArmorType = BaseArmor.ArmorTypes.MISC; }*/
	}
	void Start()
		//inicjalizacja
	{
		CreateArmor();
		Debug.Log(newArmor.ItemName);
		Debug.Log(newArmor.ItemDescription);
		Debug.Log(newArmor.ItemID.ToString());
		Debug.Log(newArmor.ArmorType.ToString());
		Debug.Log(newArmor.Stamina.ToString());
		Debug.Log(newArmor.Agility.ToString());
		Debug.Log(newArmor.Stength.ToString());
		Debug.Log(newArmor.Intellect.ToString());
		Debug.Log(newArmor.Endurance.ToString());
	}
}
