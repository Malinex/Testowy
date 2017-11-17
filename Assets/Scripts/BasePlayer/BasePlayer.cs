using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int stamina;
	private int stength;
	private int intellect;
	private int agility;
	private int endurance;

	public string PlayerName{get { return playerName; }set { playerName = value; }}
	public int PlayerLevel	{get { return playerLevel; }set { playerLevel = value; }}
	public BaseCharacterClass PlayerClass	{get { return playerClass; }set { playerClass = value; }}
	public int Stamina	{get { return stamina; } set { stamina = value; }}
	public int Stength	{get { return stength; } set { stength = value; }}
	public int Intellect{get { return intellect; }set { intellect = value; }}
	public int Agility	{get { return agility; }set { agility = value; }}
	public int Endurance{get { return endurance; }set { endurance = value; }}
}