using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour
{
	private BasePotion newPotion;
	
	public void CreatePotion()
	{
		newPotion = new BasePotion();
		newPotion.ItemName = "Potion";
		newPotion.ItemID = Random.Range(1, 101);
		//ID
		newPotion.ItemDescription = "It is a new potion";
		ChooseItemType();
		//choosing Potion Type - method
		
	}
	private void ChooseItemType()
	{
		int randomTemp = Random.Range(1, 9);
		newPotion.PotionType = (BasePotion.PotionTypes)randomTemp - 1;
		/*if (randomTemp == 1) { newPotion.PotionType = BasePotion.PotionTypes.HEALTH; }
		else if (randomTemp == 2) { newPotion.PotionType = BasePotion.PotionTypes.MANA; }
		else if (randomTemp == 3) { newPotion.PotionType = BasePotion.PotionTypes.STRENGTH; }
		else if (randomTemp == 4) { newPotion.PotionType = BasePotion.PotionTypes.INTELLECT; }
		else if (randomTemp == 5) { newPotion.PotionType = BasePotion.PotionTypes.AGILITY; }
		else if (randomTemp == 6) { newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE; }
		else if (randomTemp == 7) { newPotion.PotionType = BasePotion.PotionTypes.REJUVENATION; }
		else if (randomTemp == 8) { newPotion.PotionType = BasePotion.PotionTypes.SPEED; }*/
	}
	void Start()
		//inicjalizacja
	{
		CreatePotion();
		Debug.Log(newPotion.ItemName);
		Debug.Log(newPotion.ItemDescription);
		Debug.Log(newPotion.ItemID.ToString());
		Debug.Log(newPotion.PotionType.ToString());
	}
}
