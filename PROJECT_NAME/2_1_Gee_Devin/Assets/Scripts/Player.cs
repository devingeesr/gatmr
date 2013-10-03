using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int partCount = 0;

	// varable to use for accessing the sugarrush script
	private Sugarrush srscript;

	// Use this for initialization
	void Awake () {

	}

	// Use this for initialization
	void Start () {
		srscript = gameObject.GetComponent<Sugarrush>();	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {
		// When the player collides into the cookie 
	    if (other.tag == "miniCookie") {
	        srscript.rushbar += 10;
	        Destroy(other.gameObject);
	    }
	    if (other.tag == "Cookie") {
	        srscript.rushbar += 25;
	        Destroy(other.gameObject);
	    }
	    if (other.tag == "megaCookie") {
	        srscript.rushbar += 50;
	        Destroy(other.gameObject);
	    }    
		if (other.tag == "robot_1") {
	        srscript.rushbar -= 10;
		}
		// These code bellow is the completion or death 
	   	if (other.tag == "Finish") {
	        Application.LoadLevel("stats_Screen");
		}
	}
}