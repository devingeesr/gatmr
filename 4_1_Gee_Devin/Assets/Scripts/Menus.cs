using UnityEngine;
using System.Collections;

public class Menus : MonoBehaviour {

	// creats a public varable to define what button is what
	public bool isQuit = false;
	public bool isEasy = false;
	public bool isNormal = false;
	public bool isHard = false;
	public bool isContinue = false;
	public bool isPause = false;

	// Change color of menu text items
	void OnMouseEnter () {
		renderer.material.color = Color.red;
	}
	void OnMouseExit () {
		renderer.material.color = Color.white;
	}

	void OnMouseDown () {
		// This code allows the user to start the game or quit the game
		if (isQuit) {
			Application.Quit();
		}
		else {
			Application.LoadLevel("difficulty");			
		}
		if (Input.GetKeyDown("escape")){

		}
		// This allows the user to start level one when selecting difficulty
		if (isEasy) {
			Application.LoadLevel("level_one");
		}
		// Need the ablity to add more enemies based off difficulty
		if (isNormal) {
			Application.LoadLevel("level_one");
		}
		if (isHard) {
			Application.LoadLevel("level_one");
		}
		if (isContinue) {
			Application.LoadLevel("level_one");
		}
	}

}