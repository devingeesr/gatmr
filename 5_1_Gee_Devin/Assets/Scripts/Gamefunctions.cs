using UnityEngine;
using System.Collections;

public class Gamefunctions : MonoBehaviour {

	// Difficulty set
	public bool isEasySel	= false;
	public bool isNormalSel	= false;
	public bool isHardSel	= false;
	//Time
	public int  clock 		= 0;
	//variables for game status
	public bool isgameover 	= false;
	public bool ispaused 	= false;
	public bool isplaying 	= false;
	//Spwan
	public bool isSpwan		= false;
	public float spwanEnemy = 0;

	void Update() {
		if(isEasySel == true) {
			isSpwan		= true;
			print("15");
		}
		if(isNormalSel == true) {
			isSpwan		= true;
			print("30");
		}	
		if(isHardSel == true) {
			isSpwan		= true;
			print("45");
		}
		else{
			print("No difficulty selected!");
		}				
	}
	void OnCollisionEnter(Collision collision) {
		
	}

}
