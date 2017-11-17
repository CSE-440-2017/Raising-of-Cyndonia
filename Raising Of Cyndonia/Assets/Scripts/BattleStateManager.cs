using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateManager : MonoBehaviour 
{
	public StatesOfBattle curState;
	public List<GameObject> playersUnits = new List<GameObject>();
	public List<GameObject> enemysUnits = new List<GameObject>();

	// Use this for initialization
	void Start() 
	{
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
				break;

			case (StatesOfBattle.EnemyTurn):
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
