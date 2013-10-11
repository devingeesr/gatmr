using UnityEngine;
using System.Collections;

public class Guide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.text = "To move forward and backward use the a and s or right and left arrow key. \n To jump use the spacebar or the up key to double jump press the spacerbar or up key twice. \n To win you must get to the end of the level before the rush bar ends. \n You will lose points from your rush bar if you run into the enemy robots. \n You will die if you fall into the spike pit.";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		if(GUILayout.Button("Back to game")){
			Application.LoadLevel("Level_one");
		}
	}
}
