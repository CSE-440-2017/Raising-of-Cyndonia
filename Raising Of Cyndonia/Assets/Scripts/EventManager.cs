using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{
	public GameObject exploreCamera, battleCamera, player, enPos, plPos, emptyPos; //sets up game objects
	public List<Entity> allEnemies = new List<Entity>(); //creates a list of enemies
	public List<SkillsComponent> allSkills = new List<SkillsComponent>(); //creates a list of skills
	Entity tempEnt; //temp game object was using to switch goblins and mess with
	BattleUI bUI; //battle UI

	public Transform[] enemyBPosition; //the positions enemies can be in
	public Transform[] playerBPosition; //the positions the player's party can be in

	// Use this for initialization
	void Start() 
	{
		exploreCamera.SetActive(true); //turns on exploring player camera
		battleCamera.SetActive(false); //turns off battle camera
	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}

	public void BattleStart(RandomEncounter rEncounter)
	{
		exploreCamera.SetActive(false); //sets exploration player camera off
		battleCamera.SetActive(true); //turns the battle camera on for a battle
		Entity encounteredEnemies = GetRandomEnemy(EnemiesInLocation(rEncounter)); //gets the enemy you will encounter

		Debug.Log(encounteredEnemies.name);

		player.GetComponent<PlayerMove>().inCombat = true; //makes it so player cant move in combat

		enPos = Instantiate(emptyPos, enemyBPosition[1].transform.position, Quaternion.identity) as GameObject; //places enemy in position 1

		enPos.transform.parent = enemyBPosition[1]; //places the sprite where the enemy position 1 is
		tempEnt = enPos.AddComponent<Entity>() as Entity; //temp entity in which it will switch between different goblins based off of encounter rate
		tempEnt.AddMember(encounteredEnemies);
		enPos.GetComponent<SpriteRenderer>().sprite = encounteredEnemies.image;

		bUI.changePanel(PlayerMenu.Choice); //the change panels ui for battle based off of the choices input

	}

	//used for checking enemies that can be encountered
	public List<Entity> EnemiesInLocation(RandomEncounter rEncounter)
	{
		List<Entity> findEnemy = new List<Entity>(); //creates the list for enemies
		foreach (Entity enemy in allEnemies) //gets an encounter rate and what the enemy will be
		{
			if (enemy.chanceEncounter == rEncounter) //looks for the enemy in the list
			{
				findEnemy.Add(enemy);
			}
		}
		return findEnemy;
		
	}

	//gets the random enemy that is in the enemy list
	public Entity GetRandomEnemy(List<Entity> enemyList)
	{
		Entity eAI = new Entity(); //enemy AI entity
		int enemyNum = Random.Range(0, enemyList.Count - 1); //which enemy you will encounter
		eAI = enemyList[enemyNum]; 
		return eAI;
	}
}
