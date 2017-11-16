using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateManager : MonoBehaviour 
{
	public StatesOfBattle curState;

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
				break;
			case(StatesOfBattle.PlayerTurn):
				break;
				
		}
	}
}

public enum StatesOfBattle
{
	//Later will add animations here as well if we have time
	Start, PlayerTurn, EnemyTurn, Lose, Win
}
