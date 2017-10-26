using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour
{
	private BaseCharacterClass class1 = new BaseWarriorClass();
	private BaseCharacterClass class2 = new BaseMageClass();
	private BaseCharacterClass class3 = new BaseHunterClass();

	void OnGUI ()
	{
		GUILayout.Label(class1.CharacterClassName);
		GUILayout.Label(class1.CharacterClassDescription);
		GUILayout.Label(class1.Stength.ToString());
		GUILayout.Label(class2.CharacterClassName);
		GUILayout.Label(class2.CharacterClassDescription);
		GUILayout.Label(class2.Intellect.ToString());
		GUILayout.Label(class3.CharacterClassName);
		GUILayout.Label(class3.CharacterClassDescription);
		GUILayout.Label(class3.Agility.ToString());

	} 
}
