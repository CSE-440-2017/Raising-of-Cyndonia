using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillsComponent : MonoBehaviour 
{
	Entity entStat;
	public SkillType sType;
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

public enum SkillType
{
	Melee, Range, Magic
}