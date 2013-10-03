using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int labRobot		= 	0;
	private string itemName	=	null; //To set string to nothing you must use null

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// When the Robot is killed the player will be given an random item
		FindItem(); // This is a funciton call
	}
	void FindItem () { //This is the fucntion definition of FindItem
		labRobot = Random.Range(1, 4);
		switch(labRobot) {
			case 1:
				itemName = "Mini Cookie +10";
				DisplayMessage (itemName);
				break;
			case 2:
				itemName = "Parts +10";
				DisplayMessage (itemName);
				break;
			case 3:
				itemName = "Cookie +25";
				DisplayMessage (itemName);
				break;		
			default:
				Debug.Log("Nothing was found");
				break;

		}
	}
	void DisplayMessage(string itemName){
		Debug.Log("You found the " + itemName + "!");
	}
}