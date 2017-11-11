using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{
	public GameObject exploreCamera, battleCamera, player;
	public List<Entity> allEnemies = new List<Entity>();
	public List<SkillsComponent> allSkills = new List<SkillsComponent>();

	// Use this for initialization
	void Start() 
	{
		exploreCamera.SetActive(true);
		battleCamera.SetActive(false);
	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}

	public void BattleStart(RandomEncounter rEncounter)
	{
		exploreCamera.SetActive(false);
		battleCamera.SetActive(true);
		Entity encounteredEnemies = GetRandomEnemy(EnemiesInLocation(rEncounter));
		player.GetComponent<PlayerMove>().inCombat = true;
	}

	public List<Entity> EnemiesInLocation(RandomEncounter rEncounter)
	{
		List<Entity> findEnemy = new List<Entity>();
		foreach (Entity enemy in allEnemies)
		{
			if (enemy.chanceEncounter == rEncounter)
			{
				findEnemy.Add(enemy);
			}
		}
		return findEnemy;
		
	}

	public Entity GetRandomEnemy(List<Entity> enemyList)
	{
		Entity eAI = new Entity(); //enemy AI entity
		int enemyNum = Random.Range(0, enemyList.Count - 1);
		eAI = enemyList[enemyNum];
		return eAI;
	}
}
	/*
[System.Serializable]
public class Skills
{
	
}

[System.Serializable]
public class SkillStats
{
	
}*/
