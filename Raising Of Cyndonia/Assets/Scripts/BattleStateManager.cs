using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateManager : MonoBehaviour 
{
	public StatesOfBattle curState;
	public GameObject player, enemy;
	public PlayerParty playerUnit;
	//public EnemyParty enemyUnit;
	public List<GameObject> playersUnits = new List<GameObject>();
	public List<GameObject> enemysUnits = new List<GameObject>();
	public int unitNum;
	public BattleUI bUI;

	// Use this for initialization
	void Start() 
	{
		unitNum = 0;
		player = GameObject.FindGameObjectWithTag("Player");
		curState = StatesOfBattle.Start;

	}
	
	// Update is called once per frame
	void Update() 
	{
		switch (curState)
		{
			case (StatesOfBattle.Start):
				//setup battle function
				curState = StatesOfBattle.PlayerTurn;
				break;

			case (StatesOfBattle.PlayerTurn):
				playerUnit = player.GetComponent<PlayerInfo>().pParty[unitNum]; //grabs a unit from the players party list
				bUI.ChangePanel(PlayerMenu.Choice); //the change panels ui for battle based off of the choices input
				break;

			case (StatesOfBattle.EnemyTurn):
				//enemysUnit = enemy.GetComponent<PlayerInfo>().eParty[unitNum];
				break;

			case (StatesOfBattle.CalcDamage):
				break;

			case (StatesOfBattle.Lose):
				break;

			case (StatesOfBattle.Win):
				break;
		}
	}

	void ChangeState()
	{
	}
		
}

public enum StatesOfBattle
{
	//Later will add animations here as well if we have time
	Start, PlayerTurn, EnemyTurn, CalcDamage, Lose, Win
}
