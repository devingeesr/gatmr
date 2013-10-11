using UnityEngine;
using System.Collections;

public class DoorAnim : MonoBehaviour {

	public bool doorClose = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {
		// When the player collides into the cookie 
	    if (other.tag == "Player") {
	        animation.Play("doorbotdown");
	        animation.Play("doortopup");
	    }
	}
}
