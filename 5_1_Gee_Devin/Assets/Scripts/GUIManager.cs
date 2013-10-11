using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	public GUIText gameOverText, instructionsText;
	public GUITexture titleText;

	// Use this for initialization
	void Start () {
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		gameOverText.enabled = false;
	}
	private void GameStart () {
		gameOverText.enabled = false;
		instructionsText.enabled = false;
		titleText.enabled = false;
		enabled = false;
	}
	private void GameOver () {
		gameOverText.enabled = true;
		instructionsText.enabled = true;
		enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("KeypadEnter")){
			GameEventManager.TriggerGameStart();
		}
	
	}


}
