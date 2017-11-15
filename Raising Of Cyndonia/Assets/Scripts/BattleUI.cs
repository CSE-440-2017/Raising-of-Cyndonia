using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour 
{
	public PlayerMenu curMenu; //current menu player is on
	public GameObject choices, skills, invent, party, descrip; //different panels
	public Text attack, skill, inventory, escape, skill1, skill2, skill3, skill4; //different text
	public int curChoice; //input key for choosing
	AttackComponent AC;

	void Awake()
	{
		AC = gameObject.GetComponent<AttackComponent> ();
	}
		
	// Use this for initialization
	void Start() 
	{
		//curMenu = PlayerMenu.Choice;
	}
	
	// Update is called once per frame
	void Update() 
	{
		//gets input when pressed keys 1-4 down
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			curChoice = 1;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			curChoice = 2;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			curChoice = 3;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			curChoice = 4;
		}
		else //if a different key is pressed then sets curChoice as zero and does nothing
		{
			curChoice = 0;
		}

		//if current choice is 1-4 then it will call the player choice function
		if(curChoice >= 1 && curChoice <= 4)
		{
			PlayerChoice(curChoice);
		}

	}

	//the change panel function
	public void ChangePanel(PlayerMenu menu)
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
				descrip.gameObject.SetActive(false);
				break;
			
			//the skills panel
			case PlayerMenu.Skill:
				choices.gameObject.SetActive(false);
				skills.gameObject.SetActive(true);
				invent.gameObject.SetActive(false);
				party.gameObject.SetActive(true);
				descrip.gameObject.SetActive(false);
				break;
			
			//the inventory panel
			case PlayerMenu.Inventory:
				choices.gameObject.SetActive(false);
				skills.gameObject.SetActive(false);
				invent.gameObject.SetActive(true);
				party.gameObject.SetActive(true);
				descrip.gameObject.SetActive(false);
				break;
			
			//the description of actions panel
			case PlayerMenu.Description:
				choices.gameObject.SetActive(false);
				skills.gameObject.SetActive(false);
				invent.gameObject.SetActive(false);
				party.gameObject.SetActive(true);
				descrip.gameObject.SetActive(true);
				break;

		}
	}

	//allows player to decide on what action to take based off of the panel
	public void PlayerChoice(int choice)
	{
		switch (choice)
		{
			case 1:
				if (curMenu == PlayerMenu.Choice)
				{
					//Attack description

					ChangePanel(PlayerMenu.Description);
				}
				else if (curMenu == PlayerMenu.Skill)
				{
					//Skill 1 used description
					ChangePanel(PlayerMenu.Description);
				}
				else if (curMenu == PlayerMenu.Inventory)
				{
					//Item 1 used description
					ChangePanel(PlayerMenu.Description);
				}
				break;
			case 2:
				if (curMenu == PlayerMenu.Choice)
				{
					//Switch to skills panel
					ChangePanel(PlayerMenu.Skill);
				}
				else if (curMenu == PlayerMenu.Skill)
				{
					//Skill 2 used description
					ChangePanel(PlayerMenu.Description);
				}
				else if (curMenu == PlayerMenu.Inventory)
				{
					//Item 2 used description
					ChangePanel(PlayerMenu.Description);
				}
				break;

			case 3:
				if (curMenu == PlayerMenu.Choice)
				{
					//Switch to Inventory panel
					ChangePanel(PlayerMenu.Inventory);
				}
				else if (curMenu == PlayerMenu.Skill)
				{
					//Skill 3 used description
					ChangePanel(PlayerMenu.Choice);
				}
				else if (curMenu == PlayerMenu.Inventory)
				{
					//Item 3 used description
					ChangePanel(PlayerMenu.Description);
				}
				break;

			case 4:
				if (curMenu == PlayerMenu.Choice)
				{
					//Run Away description
					ChangePanel(PlayerMenu.Description);
				}
				else if (curMenu == PlayerMenu.Skill)
				{
					//Skill 4 used description
					ChangePanel(PlayerMenu.Description);
				}
				else if (curMenu == PlayerMenu.Inventory)
				{
					//Item 4 used description
					ChangePanel(PlayerMenu.Description);
				}
				break;

		}
	}

}

//player menu panels
public enum PlayerMenu
{
	Choice, Skill, Inventory, Description
}

public enum AttackType
{
	Fire, Ice, Thunder, Dark, Light, Wind, Water, Direct
}
