using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour 
{
	public PlayerMenu curMenu; //current menu player is on
	public GameObject choices, skills, invent, party; //different panels
	public Text attack, skill, inventory, escape, skill1, skill2, skill3, skill4; //different text
	public int curChoice; //input key for choosing


	// Use this for initialization
	void Start() 
	{
		
	}
	
	// Update is called once per frame
	void Update() 
	{
		//need to finish but this is the input for choices 1-4 on battle options
		/*if(Input.GetKeyDown(KeyCode.1))
		{
			curChoice = 1;
		}
		if(Input.GetKeyDown(KeyCode.2))
		{
			curChoice = 2;
		}
		if(Input.GetKeyDown(KeyCode.3))
		{
			curChoice = 3;
		}
		if(Input.GetKeyDown(KeyCode.4))
		{
			curChoice = 4;
		}*/
	}

	//the change panel function
	public void changePanel(PlayerMenu menu)
	{
		curMenu = menu;
		curChoice = 0;
		switch (menu)
		{
			//the beginning panel
			case PlayerMenu.Choice:				
				choices.gameObject.SetActive(true);
				skills.gameObject.SetActive(false);
				invent.gameObject.SetActive(false);
				party.gameObject.SetActive(true);
				break;
			
			//the skills panel
			case PlayerMenu.Skill:
				choices.gameObject.SetActive(false);
				skills.gameObject.SetActive(true);
				invent.gameObject.SetActive(false);
				party.gameObject.SetActive(true);
				break;
			
			//the inventory panel
			case PlayerMenu.Inventory:
				choices.gameObject.SetActive(false);
				skills.gameObject.SetActive(false);
				invent.gameObject.SetActive(true);
				party.gameObject.SetActive(true);
				break;

		}
	}

}

//player menu panels
public enum PlayerMenu
{
	Choice, Skill, Inventory
}
