using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{
	public GameObject exploreCamera, battleCamera, player, enPos, plPos, emptyPos1, emptyPos2; //sets up game objects
	public List<GameObject> allEnemies = new List<GameObject>(); //creates a list of enemies
	public int numberOfEnemies, whichEnemy; //random numbers for number of enemies and which enemies
	//public List<SkillsComponent> allSkills = new List<SkillsComponent>(); //creates a list of skills
	//public GameObject tempEnt, 
	public List<GameObject> encounteredEnemies = new List<GameObject>(); //temp game object was using to switch goblins and mess with
	BattleUI bUI; //battle UI

	public Transform[] enemyBPosition; //the positions enemies can be in
	public Transform[] playerBPosition; //the positions the player's party can be in

	// Use this for initialization
	void Start() 
	{
		//exploreCamera = GameObject.FindGameObjectWithTag("MainCamera");
		exploreCamera.SetActive(true); //turns on exploring player camera
		//battleCamera = GameObject.FindGameObjectWithTag("BattleCamera");
		battleCamera.SetActive(false); //turns off battle camera
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}

	public void BattleStart(RandomEncounter rEncounter)
	{
		numberOfEnemies = Random.Range(0, 3); //roles a random number between 0-2 on how many enemies you will encounter where 0 = 1

		exploreCamera.SetActive(false); //sets exploration player camera off
		battleCamera.SetActive(true); //turns the battle camera on for a battle
		//encounteredEnemies = GetRandomEnemy(EnemiesInLocation(rEncounter)); //gets the enemy you will encounter

		//Debug.Log(encounteredEnemies.name);

		player.GetComponent<PlayerMove>().inCombat = true; //makes it so player cant move in combat

		for (int i = 0; i < 3; i++)
		{
			plPos = Instantiate(player.GetComponent<PlayerInfo>().allParty[i], playerBPosition[i].transform.position, Quaternion.identity) as GameObject; //places enemy in position 2
			//player.GetComponent<PlayerInfo>().allParty[i].transform.position = playerBPosition[i].transform.position;
			if (i <= numberOfEnemies)
			{		
				whichEnemy = Random.Range(0, 5); //roles a random number of which random enemy in list
				//Debug.Log(encounteredEnemies[whichEnemy].name);
				//enPos = Instantiate(encounteredEnemies[whichEnemy], enemyBPosition[i].transform.position, Quaternion.identity) as GameObject;
				Debug.Log(allEnemies[whichEnemy].name); //states what random enemy it is
				enPos = Instantiate(allEnemies[whichEnemy], enemyBPosition[i].transform.position, Quaternion.identity) as GameObject; //places random enemy in enemy position
			}
		}

		/*
		//rEncounter is based off of the tile and how it is set to uncommon, common, or epic and then the gameobjects themselves have encounter rates 
		encounteredEnemies = GetRandomEnemy(EnemiesInLocation(rEncounter)); //make this enemy random as well

		enPos = Instantiate(emptyPos2, enemyBPosition[0].transform.position, Quaternion.identity) as GameObject; //places enemy in position 2

		enPos.transform.parent = enemyBPosition[0]; //places the sprite where the enemy position 2 is
		tempEnt = enPos.AddComponent<Entity>() as Entity; //temp entity in which it will switch between different goblins based off of encounter rate
		tempEnt.AddMember(GetRandomEnemy(EnemiesInLocation(rEncounter)));
		enPos.GetComponent<SpriteRenderer>().sprite = encounteredEnemies.image;
		*/

	}

	//below is used for if there is an encounter rate for each gameObject

	//used for checking enemies that can be encountered
	/*public List<GameObject> EnemiesInLocation(RandomEncounter rEncounter)
	{
		List<GameObject> findEnemy = new List<GameObject>(); //creates the list for enemies
		foreach (GameObject enemy in allEnemies) //gets an encounter rate and what the enemy will be
		{
			if (enemy.GetComponent<Entity>().chanceEncounter == rEncounter) //looks for the enemy in the list
			{
				findEnemy.Add(enemy);
				Debug.Log(enemy.name);
			}
		}
		return findEnemy;
		
	}

	//gets the random enemy that is in the enemy list
	public GameObject GetRandomEnemy(List<GameObject> enemyList)
	{
		GameObject eAI = new GameObject(); //enemy AI entity
		int enemyNum = Random.Range(0, enemyList.Count - 1); //which enemy you will encounter
		eAI = enemyList[enemyNum]; 
		return eAI;
	}*/
}
