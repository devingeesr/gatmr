using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

	public float Seconds = 15;
	public float Minutes = 0;

    void Start() {
      
    }
 	/* I need to create a function for the time then add it to the update function
    so that it can be passed to other scripts 
    */
    void Update(){
    	if(Seconds <= 0){
    		Seconds = 59;
    		if(Minutes >= 1){
    			Minutes-- ;
    		}
    		else{
    			Minutes = 0;
    			Seconds = 0;
    			Application.LoadLevel("Title_Screen");
    		}
    	}
    	else{
    		Seconds -= Time.deltaTime;
    	}
    }
}