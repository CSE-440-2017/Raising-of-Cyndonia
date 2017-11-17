using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public List<PlayerParty> pParty = new List<PlayerParty>(); //list of the players party

	// Use this for initialization
	void Start() 
	{
		
	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}
}

//players party and skills they have
//[System.Serializable]
public class PlayerParty
{
	public Entity character; //the characters that are in the party
	public List<SkillsComponent> skills = new List<SkillsComponent>(); //the skills that the party has
}