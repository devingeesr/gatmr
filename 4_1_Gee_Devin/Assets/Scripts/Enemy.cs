using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public bool isEnemyA = false;
	public bool isEnemyB = false;
	private float patrolledSoFar = 0;
	public float patrolDistance = 10;
	public float speed = 0;
	public int labRobot		= 	0;
	//private string itemName	=	null; //To set string to nothing you must use null
	private GameObject playerObject;
	CharacterController controller;
	private Sugarrush srscript;
	private Player pscript;

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController>();
		pscript = (Player)FindObjectOfType(typeof(Player));
		playerObject = pscript.gameObject;	
	}
	
	// Update is called once per frame
	void Update () {
		// When the Robot is killed the player will be given an random item
		//FindItem(); // This is a funciton call
		// This allows the enemy to track at the player 
		transform.LookAt(playerObject.transform);

		if(isEnemyA == true){
	    	patrolledSoFar = patrolledSoFar + speed;
	    	if(patrolledSoFar >= patrolDistance) {
        		transform.Rotate(0, 180, 0);
            	patrolledSoFar = 0;
      		}
      		else{

      		}
      		controller.Move(transform.forward * 0.5f + transform.up * -0.1f);
		}


	}
	/*void FindItem () { //This is the fucntion definition of FindItem
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
	}*/

	void OnTriggerEnter(Collider other) {
		if(other.name == "Player") {
		srscript.rushbar -= 25;
		}
	}
}