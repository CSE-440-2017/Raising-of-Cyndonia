using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour 
{
	Entity entInfo; //grabs values from entity script
	int maxHP, currentHP, regenAmount; //values for the gameObjects health or healing
	bool regenHP, dead; //bool to check if allowed to regen health or is dead

	void Awake()
	{
		//set all of the values
		entInfo = gameObject.GetComponent<Entity>();
		maxHP = entInfo.HitPoints;
		regenAmount = entInfo.HitPointReg;
		regenHP = entInfo.CanRegen;
		dead = entInfo.IsDead;
		currentHP = maxHP;
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
	public float HealthDamaged(int damage)
	{
		currentHP -= damage;
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
