using UnityEngine;
using System.Collections;

public class StatsScreen : MonoBehaviour {
    /*I need to import the following stats
    all of these variables are in the 
    game functions script
        - cookieCounter 
        - partsCounter 
        - timeCounter
    The player will receive an overall score 
    based on the stats of the variable above.
    */
	public float Seconds       = 15;
	public float Minutes       = 0;
    private Sugarrush          srscript;
    //static public int rushScore = srscript.rushbar;

    void Start() {
        //gfsripts = gameObject.GetComponent<gfsripts>();
        srscript    = gameObject.GetComponent<Sugarrush>(); 
    }
 	
    void Update(){
    	if(Seconds <= 0){
    		Seconds = 59;
    		if(Minutes >= 1){
    			Minutes-- ;
    		}

    	}
    	else{
    		Seconds -= Time.deltaTime;
    	}
    }
    //void OnGUI{
    //    GUILayout.Label(new Rect(10,10,100,20)"rushScore");
    //}
}