using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateManager : MonoBehaviour 
{
	public StatesOfBattle currentState; //state of the battle
	public GameObject player, enemy, playerUnit; //player, enemy, and the party of player and enemy game objects
	//not sure we will be using these yet
	//public PlayerParty playerUnit; 
	//public EnemyParty enemyUnit;
	//public List<GameObject> playersUnits = new List<GameObject>();
	//public List<GameObject> enemysUnits = new List<GameObject>();
	public int unitNum;
	public BattleUI bUI;

	// Use this for initialization
	void Start() 
	{
		unitNum = 0; //which unit will be going
		player = GameObject.FindGameObjectWithTag("Player"); //sets up the player will have a setup for enemy as well
		currentState = StatesOfBattle.Start; //sets the current state to start
	}
	
	// Update is called once per frame
	void Update() 
	{
		Debug.Log (currentState);
		switch (currentState)
		{
			case (StatesOfBattle.Start):
				//setup battle function
				bUI.ChangePanel(PlayerMenu.Choice);
				currentState = StatesOfBattle.PlayerTurn;
				break;

			case (StatesOfBattle.PlayerTurn): //players turn goes through until all party members have done something
			
				//Sets it so that as long as unitNum is less than the list size of the player then the player can chose there choices
				if(unitNum < player.GetComponent<PlayerInfo>().allParty.Count)
					playerUnit = player.GetComponent<PlayerInfo>().allParty[unitNum]; //grabs a unit from the players party list

				else 
					currentState = StatesOfBattle.EnemyTurn;

				//bUI.ChangePanel(PlayerMenu.Choice); //the change panels ui for battle based off of the choices input
				//Debug.Log("Players Turn, Party Member " + unitNum);

				break;

			case (StatesOfBattle.EnemyTurn): //enemies turn goes through until all enemies have done something
				//enemysUnit = enemy.GetComponent<PlayerInfo>().eParty[unitNum];
				break;

			case (StatesOfBattle.CalcDamage): //calculates the damage done
				break;

			case (StatesOfBattle.Lose): //set up if player loses
				break;

			case (StatesOfBattle.Win): //set up if player wins
				break;
		}
	}

	//was for changeing states have not finished it
	void ChangeState()
	{
	}
		
}

public enum StatesOfBattle
{
	//Later will add animations here as well if we have time
	Start, PlayerTurn, EnemyTurn, CalcDamage, Lose, Win
}
