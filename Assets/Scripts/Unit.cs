using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{

	public string unitName;
	public int unitLevel;

	public int damage;
	public int KatanaDamage;
	public int PlaneDamage;

	public int maxHP;
	public int currentHP;

	public bool TakeDamage(int damage)
	{
		currentHP -= damage;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public bool TakeKatanaDamage(int KatanaDamage)
	{
		currentHP -= KatanaDamage;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public bool TakePlaneDamage(int PlaneDamage)
	{
		currentHP -= PlaneDamage;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public void Heal(int amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}

}