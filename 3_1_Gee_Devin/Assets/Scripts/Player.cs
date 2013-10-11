using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int partCount = 0;

	// varable to use for accessing the sugarrush script
	private Sugarrush srscript;
	//private Enemy escript;

	// Use this for initialization
	void Start () {
		srscript	= gameObject.GetComponent<Sugarrush>();	
	//	escript		= gameObject.GetComponent<Enemy>();
	}
	
	// Update is called once per frame
	void Update () {
		if(srscript.rushbar <= 0){
			Application.LoadLevel("death_Screen");
		}
	}
	void OnTriggerEnter(Collider addCookie) {
		// When the player collides into the cookie 
	    if (addCookie.tag == "miniCookie") {
	        srscript.rushbar += 10;
	        Destroy(addCookie.gameObject);
	    }
	    if (addCookie.tag == "Cookie") {
	        srscript.rushbar += 25;
	        Destroy(addCookie.gameObject);
	    }
	    if (addCookie.tag == "megaCookie") {
	        srscript.rushbar += 50;
	        Destroy(addCookie.gameObject);
	    } 
		if (addCookie.tag == "robotA") {
	        srscript.rushbar -= 10;
		}	       
		if (addCookie.tag == "disEnemy") {
	        Destroy(addCookie.gameObject);
		}
		if (addCookie.tag == "openDoor") {
	        srscript.rushbar -= 10;
		}
		// These code bellow is the completion or death 
	   	if (addCookie.tag == "Finish") {
	        Application.LoadLevel("stats_Screen");
		}
		if (addCookie.tag == "instDeath") {
			Application.LoadLevel("Gameover");
		}
	}
}