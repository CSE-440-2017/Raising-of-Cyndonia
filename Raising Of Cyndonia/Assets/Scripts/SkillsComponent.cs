using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillsComponent : MonoBehaviour 
{
	Entity entStat; //gets the entity's stats
	public SkillType sType; //determines the type of skill used
	[SerializeField] string name; 


	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}
}

//allows for melee type, range type, and magic type of skills
public enum SkillType
{
	Melee, Range, Magic
}