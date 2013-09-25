using UnityEngine;
using System.Collections;

public class StatsScreen : MonoBehaviour {

	public float Seconds = 15;
	public float Minutes = 0;

    void Start() {
      
    }
 	
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