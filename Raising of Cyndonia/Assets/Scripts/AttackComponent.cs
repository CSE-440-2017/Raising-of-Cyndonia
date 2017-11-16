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

	void Attack(GameObject other)
	{
		int dmgPercent = Random.Range (0, 100);
		float dmgPercentage = dmgPercent / 100;

		if (other.gameObject.GetComponent<Entity> ().Weakness.ToString() == bUI.magicType.ToString()) {
			if (bUI.attackType.ToString () == "Direct" || entInfo.Role.ToString () == "Knight") {
				baseDMG *= 1.5f;
				updatedDMG = baseDMG * dmgPercentage;
				totalDMG = (int)baseDMG - (int)updatedDMG;
				HC.HealthDamaged (totalDMG);
			} 

			else if (bUI.attackType.ToString () == "Magic" || entInfo.Role.ToString () == "Mage") {
				magicDMG *= 1.5f;
				updatedDMG = magicDMG * dmgPercentage;
				totalDMG = (int) magicDMG - (int) updatedDMG;
				HC.HealthDamaged (totalDMG);
			}
		}

		else if (bUI.attackType.ToString () == "Direct" && entInfo.Role.ToString () == "Knight") {
			baseDMG *= 1.5f;
			updatedDMG = baseDMG * dmgPercentage;
			totalDMG = (int)baseDMG - (int)updatedDMG;
			HC.HealthDamaged (totalDMG);
		} 

		else if (bUI.attackType.ToString () == "Magic" && entInfo.Role.ToString () == "Mage") {
			magicDMG *= 1.5f;
			updatedDMG = magicDMG * dmgPercentage;
			totalDMG = (int)magicDMG - (int)updatedDMG;
			HC.HealthDamaged (totalDMG);
		}

		else if (bUI.attackType.ToString () == "Direct") {
			updatedDMG = baseDMG * dmgPercentage;
			totalDMG = (int)baseDMG - (int)updatedDMG;
			HC.HealthDamaged (totalDMG);
		} 

		else if (bUI.attackType.ToString () == "Magic") {
			updatedDMG = magicDMG * dmgPercentage;
			totalDMG = (int)magicDMG - (int)updatedDMG;
			HC.HealthDamaged (totalDMG);
		}
	}
}