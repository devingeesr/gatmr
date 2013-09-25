using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public bool rushCount = 0;
	public health = health; 
	public bool partCount = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		// When the player collides into the cookie 
	    if (other.tag == "miniCookie") {
	        score += 10;
	        Destroy(other.gameObject);
	    }
	    if (other.tag == "Cookie") {
	        score += 25;
	        Destroy(other.gameObject);
	    }
	    if (other.tag == "megaCookie") {
	        score += 50;
	        Destroy(other.gameObject);
	    }    

	    // When the player reaches the goal
	   	if (other.tag == "Finish") {
	        Application.LoadLevel("stats_Screen");
		}
	}
}