using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttackComponent : MonoBehaviour {
	Entity entInfo;
	HealthComponent HC;
	BattleUI bUI;
	[SerializeField] float baseDMG, magicDMG, specDMG;
	int totalDMG;
	float updatedDMG;

	void Awake()
	{
		entInfo = gameObject.GetComponent <Entity> ();
		HC = gameObject.GetComponent <HealthComponent> ();
		bUI = gameObject.GetComponent <BattleUI> ();

		baseDMG = entInfo.Damage;
		magicDMG = entInfo.MagicDamage;
		specDMG = entInfo.SpecialDamage; 
	}

	//need to draw this back to the basics in order to just do the attacking and health depletion bars
	/*void Attack(GameObject other)
	{
		//Get a random percentage to determine how effective the attack will be
		int dmgPercent = Random.Range (0, 100);
		float dmgPercentage = dmgPercent / 100;

		//See if the attack the entity chose is a weakness of the entity they are attacking
		if (other.GetComponent<Entity> ().Weakness.ToString () == bUI.magicType.ToString ()) {
			//See if the attack is a direct attack then increase the base damage by 1.5 and then attack the entity 
			if (bUI.attackType.ToString () == "Direct") {
				baseDMG *= 1.5f;
				updatedDMG = baseDMG * dmgPercentage;
				totalDMG = (int)baseDMG - (int)updatedDMG;
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			} 

			//See fi the attack is a magic attack then increase the magic damage by 1.5 and then attack the entity
			else if (bUI.attackType.ToString () == "Magic") {
				magicDMG *= 1.5f;
				updatedDMG = magicDMG * dmgPercentage;
				totalDMG = (int)magicDMG - (int)updatedDMG;
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			}
		} 

		//See if the attack the entity chose is not as effective to the entity they are attacking
		else if (other.GetComponent<Entity> ().Invulnerable.ToString () == bUI.magicType.ToString ()) {
			if (bUI.attackType.ToString () == "Direct") {
				baseDMG /= 1.5f;
				updatedDMG = baseDMG * dmgPercentage;
				totalDMG = (int)baseDMG - (int)updatedDMG;
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			} 

			else if (bUI.attackType.ToString () == "Magic") {
				magicDMG /= 1.5f;
				updatedDMG = magicDMG * dmgPercentage;
				totalDMG = (int)magicDMG - (int)updatedDMG;
				other.GetComponent<HealthComponent> ().HealthDamaged (totalDMG);
			}
		}

		//See if the entity is a knight and using a direct attack and as a result the base attack is boosted
		else if (bUI.attackType.ToString () == "Direct" && entInfo.Role.ToString () == "Knight") {
			baseDMG *= 1.5f;
			updatedDMG = baseDMG * dmgPercentage;
			totalDMG = (int)baseDMG - (int)updatedDMG;
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		} 

		//See if the entity is a mage and using a magic attack and as a result the magic attack is boosted
		else if (bUI.attackType.ToString () == "Magic" && entInfo.Role.ToString () == "Mage") {
			magicDMG *= 1.5f;
			updatedDMG = magicDMG * dmgPercentage;
			totalDMG = (int)magicDMG - (int)updatedDMG;
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		}

		//See if the attack is just a direct attack so just do the attack
		else if (bUI.attackType.ToString () == "Direct") {
			updatedDMG = baseDMG * dmgPercentage;
			totalDMG = (int)baseDMG - (int)updatedDMG;
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		} 

		//See if the attack is a magic attack and if so then just do the attack
		else if (bUI.attackType.ToString () == "Magic") {
			updatedDMG = magicDMG * dmgPercentage;
			totalDMG = (int)magicDMG - (int)updatedDMG;
			other.GetComponent<HealthComponent>().HealthDamaged (totalDMG);
		}
	}*/
}