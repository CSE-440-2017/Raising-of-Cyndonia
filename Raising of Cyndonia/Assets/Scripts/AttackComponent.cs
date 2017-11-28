﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttackComponent : MonoBehaviour {
	Entity entInfo;
	HealthComponent HC;
	BattleUI bUI;
	[SerializeField] int baseDMG, magicDMG, specDMG;
	[SerializeField] int totalDMG;
	[SerializeField] float updatedDMG;
	[SerializeField] AttackType playerAttack;
	//Entity entInfo = gameObject.GetComponent <Entity> ();

	/*void Start()
	{
		entInfo = gameObject.GetComponent <Entity> ();
		HC = gameObject.GetComponent <HealthComponent> ();
		bUI = gameObject.GetComponent <BattleUI> ();

		playerAttack = entInfo.Attacks;
		baseDMG = entInfo.Damage;
		Debug.Log(" Base " + baseDMG);
		magicDMG = entInfo.MagicDamage;
		specDMG = entInfo.SpecialDamage; 
	}*/

	//need to draw this back to the basics in order to just do the attacking and health depletion bars
	public void Attack(GameObject other)
	{
		entInfo = gameObject.GetComponent<Entity>(); //The gameObjects Entity
		baseDMG = entInfo.Damage; //gameObjects base damage
		HC = gameObject.GetComponent <HealthComponent> (); //gameObjects health
		//bUI = gameObject.GetComponent <BattleUI> (); //gameObjects bUI

		playerAttack = entInfo.Attacks;
		baseDMG = entInfo.Damage;
		magicDMG = entInfo.MagicDamage;
		specDMG = entInfo.SpecialDamage; 
		Debug.Log("The Base Damage in Attack " + baseDMG);
		Debug.Log(gameObject);
		//Get a random percentage to determine how effective the attack will be
		float dmgPercent = Random.Range (0, 100);
		float dmgPercentage = dmgPercent / 100;
		Debug.Log("DMG Percent" + dmgPercentage);
		//See if the attack the entity chose is a weakness of the entity they are attacking
		/*if (other.GetComponent<Entity> ().Weakness.ToString () == entInfo.Magic.ToString ()) {
			//See if the attack is a direct attack then increase the base damage by 1.5 and then attack the entity 
			if (entInfo.Attacks.ToString () == "Melee") {
				baseDMG *= 1.5f; //Calculates how much to increase the base damage to
				updatedDMG = baseDMG * dmgPercentage;//See's how effective the damage will be 
				totalDMG = (int)baseDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			} 

			//See fi the attack is a magic attack then increase the magic damage by 1.5 and then attack the entity
			else if (entInfo.Attacks.ToString () == "Magic") {
				magicDMG *= 1.5f;//Calculates how much to increase the base magic damage to
				updatedDMG = magicDMG * dmgPercentage;//Calculates how much to increase the base magic damage to 
				totalDMG = (int)magicDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			}
		} 

		//See if the attack the entity chose is not as effective to the entity they are attacking
		else if (other.GetComponent<Entity> ().Invulnerable.ToString () == entInfo.Magic.ToString ()) {
			if (entInfo.Attacks.ToString () == "Melee") {
				baseDMG /= 1.5f; //Calculates how much to decrease the base damage 
				updatedDMG = baseDMG * dmgPercentage; //See how effective the damage will be
				totalDMG = (int)baseDMG - (int)updatedDMG; //Subtract the base damage from the updated damage to give proper value
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			} 

			else if (entInfo.Attacks.ToString () == "Magic") {
				magicDMG /= 1.5f;//Calculates how much to decrease the base magic damage 
				updatedDMG = magicDMG * dmgPercentage;//See how effective the damage will be
				totalDMG = (int)magicDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			}
		}

		//See if the entity is a knight and using a direct attack and as a result the base attack is boosted
		else if (entInfo.Attacks.ToString () == "Melee" && entInfo.Role.ToString () == "Knight") {
			baseDMG *= 1.5f;//Calculates how much to increase the base damage by
			updatedDMG = baseDMG * dmgPercentage;//See how effective the damage will be
			totalDMG = (int)baseDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		} 

		//See if the entity is a mage and using a magic attack and as a result the magic attack is boosted
		else if (entInfo.Attacks.ToString () == "Magic" && entInfo.Role.ToString () == "Mage") {
			magicDMG *= 1.5f;//Calculates how much to increase the base magic damage by 
			updatedDMG = magicDMG * dmgPercentage;//See how effective the damage will be
			totalDMG = (int)magicDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		}*/

		//See if the attack is just a direct attack so just do the attack
		if (playerAttack == AttackType.Melee) 
		{
			//if (gameObject.Attacks == AttackType.Melee) {
			updatedDMG = baseDMG * dmgPercentage;//See how effective the damage will be
			Debug.Log("base " + baseDMG);
			Debug.Log("updated " + updatedDMG);
			totalDMG = (int)baseDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
			Debug.Log("total dmg " + totalDMG);
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
			Debug.Log(other);
		} 

		//See if the attack is a magic attack and if so then just do the attack
		else if (playerAttack == AttackType.Magic) 
		{
			updatedDMG = magicDMG * dmgPercentage;//See how effective the damage will be
			totalDMG = (int)magicDMG - (int)updatedDMG;//Subtracts the base damage with the updated damge to give proper damage value
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		}
	}
}

