using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

[System.Serializable]
public class Entity : MonoBehaviour 
{
	[SerializeField] bool isDead, isPlayer, canAttack, inCombat, interactable, statusEffect, canRecruit, canRegen;
	[SerializeField] int level, hitPoints, skillPoints, hitPointReg;
	[SerializeField] int damage;
	public RandomEncounter chanceEncounter;

	// Update is called once per frame
	void Update() 
	{

	}

	public bool IsDead //checks if object is alive
	{
		get { return isDead; }
	}

	public bool IsPlayer //checks if object is a player
	{
		get { return isPlayer; }
	}

	public bool CanAttack //checks if object can attack
	{
		get { return canAttack; }
	}

	public bool InCombat //checks if in combat
	{
		get { return inCombat; }
	}

	public bool Interactable //checks if interactable
	{
		get { return interactable; }
	}

	public bool StatusEffect //checks if there is a status effect
	{
		get { return statusEffect; }
	}

	public bool CanRecruit //checks if object can be recruited to party
	{
		get { return canRecruit; }
	}

	public bool CanRegen //checks if possible to regen
	{
		get { return canRegen; }
	}

	public int Level //finds out the level of object
	{
		get { return level; }
	}

	public int HitPoints //finds out the objects hitpoints
	{
		get { return hitPoints; }
	}

	public int SkillPoints //finds out how many skill points there are
	{
		get { return skillPoints; }
	}

	public int HitPointReg //finds out how much regeneration will heal
	{
		get { return hitPointReg; }
	}

	public float Damage //finds out the damage the object will do
	{
		get { return damage; }
	}
}
