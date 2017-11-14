using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComponent : MonoBehaviour {
	Entity stats;
	[SerializeField] int entityRegDmg, entityMagDmg, entitySpecDmg;
	GameObject player;
	//GameObject Enemy;

	void Awake(){
		stats = gameObject.GetComponent<Entity> ();
		entityRegDmg = stats.RegDamage;
		entityMagDmg = stats.MagDamage;
		entitySpecDmg = stats.SpecDamage;

		player = GameObject.FindGameObjectWithTag ("Player");
		//Enemy = GameObject.FindGameObjectWithTag ("Enemy");
	}

	void doRegAttack(){
		if (gameObject.tag == "Enemy")
			player.GetComponent<HealthComponent>().HealthDamaged (entityRegDmg);
		//else
			//Enemy.GetComponent <HealthComponent>().HealthDamaged (entityRegDmg);
	}
		
	void doMagAttack(){
		if (gameObject.tag == "Enemy")
			player.GetComponent<HealthComponent> ().HealthDamaged (entityMagDmg);
		//else
			//Enemy.GetComponent <HealthComponent> ().HealthDamaged (entityMagDmg);
	}

	void doSpecAttack(){
		if (gameObject.tag == "Enemy")
			player.GetComponent<HealthComponent> ().HealthDamaged (entitySpecDmg);
		//else
			//Enemy.GetComponent <HealthComponent> ().HealthDamaged (entitySpecDmg);
	}
}
