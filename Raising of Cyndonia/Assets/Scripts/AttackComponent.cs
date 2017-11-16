using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttackComponent : MonoBehaviour {
	Entity entInfo;
	HealthComponent HC;
	[SerializeField] int baseDMG, magicDMG, specDMG, dodge;

	void Awake()
	{
		entInfo = gameObject.GetComponent <Entity> ();
		HC = gameObject.GetComponent <HealthComponent> ();

		baseDMG = entInfo.Damage;
		magicDMG = entInfo.MagicDamage;
		specDMG = entInfo.SpecialDamage; 
	}

	void Attack(GameObject other)
	{
		if(other.gameObject.GetComponent<Entity>().Weakness ==
}
