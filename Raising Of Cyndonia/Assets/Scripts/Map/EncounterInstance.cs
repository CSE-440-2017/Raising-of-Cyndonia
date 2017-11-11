using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EncounterInstance : MonoBehaviour 
{
	public LocationList Cave;
	private EventManager eMan;
	[SerializeField] float comChance, uncomChance, epicChance, encoChance;

	// Use this for initialization
	void Start()
	{
		eMan = GameObject.FindGameObjectWithTag("EventManager").GetComponent<EventManager>();
	}
		
	// Update is called once per frame
	void Update() 
	{
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.GetComponent<PlayerMove>()) 
		{			
			comChance = 10.0f / 150.0f;
			uncomChance = 6.0f / 150.0f; 
			epicChance = 2.5f / 150.0f;

			encoChance = Random.Range(0.0f, 100.0f);
			if (encoChance < epicChance * 100)
			{
				if (eMan != null)
				{
					eMan.BattleStart (RandomEncounter.Epic);
				}
			}
			else if (encoChance < uncomChance * 100)
			{
				if (eMan != null)
				{
					eMan.BattleStart (RandomEncounter.Uncommon);
				}
			}
			else if (encoChance < comChance * 100)
			{
				if (eMan != null)
				{
					eMan.BattleStart (RandomEncounter.Common);
				}
			}
		}
	}

}
