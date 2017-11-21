﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour 
{
	Entity entInfo; //grabs values from entity script
	Slider healthBar;
	int maxHP, currentHP, regenAmount, defenseVal; //values for the gameObjects health or healing
	bool regenHP, dead, defenseAct; //bool to check if allowed to regen health or is dead

	void Awake()
	{
		//set all of the values
		entInfo = gameObject.GetComponent<Entity>();
		maxHP = entInfo.MaxHitPoints;
		regenAmount = entInfo.HitPointReg;
		defenseVal = entInfo.Defense;
		regenHP = entInfo.CanRegen;
		dead = entInfo.IsDead;
		defenseAct = entInfo.DefenseActive;
		currentHP = entInfo.HitPoints;
		healthBar.value = currentHP;
		healthBar.maxValue = maxHP;
	}

	//Update once per frame
	void Update()
	{
		//if entity's current hp is not max and is allowed to regen then entity regens hp
		if (currentHP != maxHP && !regenHP) 
		{
			//some regen function
		}
	}

	//if gameObject is attacked it will take damage
	public int HealthDamaged(int damage)
	{
		//Check to see if defense is active
		if (defenseAct) {
			//If defense is active than reduce the damage by the defense value of the entity
			damage -= defenseVal;

			//If the damage is greater than 0 then subtract the amount of damage from player's health
			//and update the health bar to show the change
			if (damage > 0) {
				currentHP -= damage;
				healthBar.value = currentHP;
			}
		} 

		//Else if defense if off then just subtract the amount of damage from player's health and update
		//the health bar to show the change
		else if (damage > 0) 
		{
			currentHP -= damage;
			healthBar.value = currentHP;
		}
		
		return currentHP;
	}

	public void Regen()
	{
		//some regen function until regen effect ends
	}

	//returns health or if zero then calls Die function
	public float Health()
	{
		if (currentHP <= 0)
		{
			Die();
		}
		return currentHP;
	}

	//allows gameObject to heal
	public float Heal(int amount)
	{
		currentHP += amount;
		healthBar.value = currentHP;
		return currentHP;
	}

	//sets gameObject to dead
	public bool Die()
	{
		dead = true;
		Destroy(gameObject); //destroys gameObject if dead
		return dead;
	}

}
