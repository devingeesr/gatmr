using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int rushCount = 0;
	public int drushCount = 0;

	public int partCount = 0;

	public int maxHealth = 100;
	public int curHealth = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {
		// When the player collides into the cookie 
	    if (other.tag == "miniCookie") {
	        maxHealth += 10;
	        Destroy(other.gameObject);
	    }
	    if (other.tag == "Cookie") {
	        maxHealth += 25;
	        Destroy(other.gameObject);
	    }
	    if (other.tag == "megaCookie") {
	        maxHealth += 50;
	        Destroy(other.gameObject);
	    }    
		if (other.tag == "robot_1") {
	        maxHealth -= 10;
		}
		// These code bellow is the completion or death 
	   	if (other.tag == "Finish") {
	        Application.LoadLevel("stats_Screen");
		}
	}
}