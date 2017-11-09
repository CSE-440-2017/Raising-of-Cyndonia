using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyEncounter : MonoBehaviour 
{
	public string name;
	public Sprite image;
	public LocationList locationIn;
	Entity entInfo;

	// Use this for initialization
	void Start() 
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
}

public enum RandomEncounter
{
	Common, Uncommon, Epic
}

public enum Enemies
{
	
}