using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewScroll : MonoBehaviour
{
	private BaseScroll newScroll;
	
	public void CreateScroll()
	{
		newScroll = new BaseScroll();
		newScroll.ItemName = "Scroll";
		newScroll.ItemID = Random.Range(1, 101);
		//ID
		newScroll.ItemDescription = "It is a new Scroll";
		newScroll.SpellEffectID = Random.Range(500, 1001);
		ChooseItemType();
		//choosing Potion Type - method
		
	}
	private void ChooseItemType()
	{
		int randomTemp = Random.Range(1, 9);
		newScroll.ScrollType = (BaseScroll.ScrollTypes)randomTemp - 1;
		/*if (randomTemp == 1) { newScroll.ScrollType = BaseScroll.ScrollTypes.STAMINA; }
		else if (randomTemp == 2) { newScroll.ScrollType = BaseScroll.ScrollTypes.PROTECTION; }
		else if (randomTemp == 3) { newScroll.ScrollType = BaseScroll.ScrollTypes.STRENGTH; }
		else if (randomTemp == 4) { newScroll.ScrollType = BaseScroll.ScrollTypes.INTELLECT; }
		else if (randomTemp == 5) { newScroll.ScrollType = BaseScroll.ScrollTypes.AGILITY; }*/
	}
	void Start()
		//inicjalizacja
	{
		CreateScroll();
		Debug.Log(newScroll.ItemName);
		Debug.Log(newScroll.ItemDescription);
		Debug.Log(newScroll.ItemID.ToString());
		Debug.Log(newScroll.ScrollType.ToString());
		Debug.Log(newScroll.SpellEffectID.ToString());
	}
}
