using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour 
{
	public PlayerMenu curMenu; //current menu player is on
	public GameObject choices, skills, invent, party, magic1, magic2, special, descrip; //different panels
	public Text attack, skill, inventory, escape, skill1, skill2, skill3, skill4; //different text
	public int curChoice; //input key for choosing
	public AttackTypes AT;
	public MagicTypes MT;
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
		if (Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.Keypad1)) 
			curChoice = 1;
		
		else if (Input.GetKeyDown (KeyCode.Alpha2) || Input.GetKeyDown (KeyCode.Keypad2)) 
			curChoice = 2;
		
		else if (Input.GetKeyDown (KeyCode.Alpha3) || Input.GetKeyDown (KeyCode.Keypad3)) 
			curChoice = 3;
		
		else if (Input.GetKeyDown (KeyCode.Alpha4) || Input.GetKeyDown (KeyCode.Keypad4)) 
			curChoice = 4;
		
		else if (Input.GetKeyDown (KeyCode.Alpha5) || Input.GetKeyDown (KeyCode.Keypad5)) 
			curChoice = 5;
		
		else //if a different key is pressed then sets curChoice as zero and does nothing
			curChoice = 0;

		//if current choice is 1-4 then it will call the player choice function
		if(curChoice >= 1 && curChoice <= 5)
			PlayerChoice(curChoice);

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
			choices.gameObject.SetActive (true);
			skills.gameObject.SetActive (false);
			magic1.gameObject.SetActive (false);
			magic2.gameObject.SetActive (false);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (false);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (false);
			break;

			//the skills panel
		case PlayerMenu.Skill:
			choices.gameObject.SetActive (false);
			skills.gameObject.SetActive (true);
			magic1.gameObject.SetActive (false);
			magic2.gameObject.SetActive (false);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (false);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (false);
			break;

			//the magic 1 panel
		case PlayerMenu.Magic1:
			choices.gameObject.SetActive (false);
			skills.gameObject.SetActive (false);
			magic1.gameObject.SetActive (true);
			magic2.gameObject.SetActive (false);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (false);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (false);
			break;

			//the magic 2 panel
		case PlayerMenu.Magic2:
			choices.gameObject.SetActive (false);
			skills.gameObject.SetActive (false);
			magic1.gameObject.SetActive (false);
			magic2.gameObject.SetActive (true);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (false);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (false);
			break;

			//the special attack panel
		case PlayerMenu.Special:
			choices.gameObject.SetActive (false);
			skills.gameObject.SetActive (false);
			magic1.gameObject.SetActive (false);
			magic2.gameObject.SetActive (false);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (false);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (true);
			break;

			//the inventory panel
		case PlayerMenu.Inventory:
			choices.gameObject.SetActive (false);
			skills.gameObject.SetActive (false);
			magic1.gameObject.SetActive (false);
			magic2.gameObject.SetActive (false);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (true);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (false);
			break;

			//the description of actions panel
		case PlayerMenu.Description:
			choices.gameObject.SetActive (false);
			skills.gameObject.SetActive (false);
			magic1.gameObject.SetActive (false);
			magic2.gameObject.SetActive (false);
			special.gameObject.SetActive (false);
			invent.gameObject.SetActive (false);
			party.gameObject.SetActive (true);
			descrip.gameObject.SetActive (true);
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
				AT = AttackTypes.Direct;
				MT = MagicTypes.Direct;
				ChangePanel (PlayerMenu.Description);
			} 

			else if (curMenu == PlayerMenu.Skill) 
			{
				//Skill 1 used description
				ChangePanel (PlayerMenu.Magic1);
			} 
			else if (curMenu == PlayerMenu.Magic1) 
			{
				//
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Magic2) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Special) 
			{
				ChangePanel (PlayerMenu.Description);
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
				//Attack description
				ChangePanel (PlayerMenu.Description);
			} 

			else if (curMenu == PlayerMenu.Skill) 
			{
				//Skill 1 used description
				ChangePanel (PlayerMenu.Description);
			} 
			else if (curMenu == PlayerMenu.Magic1) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Magic2) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Special) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Inventory)
			{
				//Item 1 used description
				ChangePanel(PlayerMenu.Description);
			}
			break;

		case 3:
			if (curMenu == PlayerMenu.Choice) 
			{
				//Attack description
				ChangePanel (PlayerMenu.Skill);
			} 

			else if (curMenu == PlayerMenu.Skill) 
			{
				//Skill 1 used description
				ChangePanel (PlayerMenu.Choice);
			} 
			else if (curMenu == PlayerMenu.Magic1) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Magic2) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Special) 
			{
				ChangePanel (PlayerMenu.Choice);
			}
			else if (curMenu == PlayerMenu.Inventory)
			{
				//Item 1 used description
				ChangePanel(PlayerMenu.Description);
			}
			break;

		case 4:
			if (curMenu == PlayerMenu.Choice) 
			{
				//Attack description
				ChangePanel (PlayerMenu.Description);
			} 

			else if (curMenu == PlayerMenu.Skill) 
			{
				//Skill 1 used description
				ChangePanel (PlayerMenu.Magic1);
			} 
			else if (curMenu == PlayerMenu.Magic1) 
			{
				ChangePanel (PlayerMenu.Magic2);
			}
			else if (curMenu == PlayerMenu.Magic2) 
			{
				ChangePanel (PlayerMenu.Description);
			}
			else if (curMenu == PlayerMenu.Inventory)
			{
				//Item 1 used description
				ChangePanel(PlayerMenu.Description);
			}
			break;

		case 5:
			if (curMenu == PlayerMenu.Choice) {
				//Attack description
				ChangePanel (PlayerMenu.Description);
			} 
			else if (curMenu == PlayerMenu.Magic1) {
				ChangePanel (PlayerMenu.Skill);
			} 
			else if (curMenu == PlayerMenu.Magic2) {
				ChangePanel (PlayerMenu.Magic1);
			} 
			else if (curMenu == PlayerMenu.Inventory) {
				//Item 1 used description
				ChangePanel (PlayerMenu.Description);
			}
			break;
		}
	}
		
	public AttackTypes attackType {
		get{ return AT; }
	}

	public MagicTypes magicType {
		get{ return MT; }
	}
}

//player menu panels
public enum PlayerMenu
{
	Choice, Attack, Skill, Inventory, Magic1, Magic2, Special, Description
}

public enum AttackTypes
{
	Magic, Direct, Special, Block
}

public enum MagicTypes
{
	Fire, Ice, Thunder, Dark, Light, Wind, Water, Direct, Heal
}
