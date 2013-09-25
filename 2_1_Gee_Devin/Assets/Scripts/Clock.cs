using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {

	public float Seconds = 59;
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
    			Seconds = 0;// This makes the guiText show the time as X:XX. ToString.("f0") formats it to theere is no decimal place.
    			GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
    			Application.LoadLevel("Death_Screen");
    		}
    	}
    	else{
    		Seconds -= Time.deltaTime;
    	}
    	// These lines will make aure the time is shown as X:XX and not X:XX.XXXXXX
    	if(Mathf.Round(Seconds) <= 9) {
    		GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
    	}
    	else{
    		GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
    	}
    }
}