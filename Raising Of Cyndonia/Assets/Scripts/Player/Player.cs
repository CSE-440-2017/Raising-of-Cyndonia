using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public List<Entity> playerParty = new List<Entity>();

	// Use this for initialization
	void Start() 
	{
		
	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}
}

[System.Serializable]
public class PlayerParty
{
	public Entity character;
	public List<SkillsComponent> skills = new List<SkillsComponent>();
}