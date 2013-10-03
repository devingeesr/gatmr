using UnityEngine;
using System.Collections;

public class Gamefunctions : MonoBehaviour {


	// varable to use for accessing the sugarrush script
	private Sugarrush srscript;

	public float timer = 120f;
    float startTime;
    TextMesh timerText;
    private Display display;

	// Use this for initialization
	void Start () {
		srscript = gameObject.GetComponent<Sugarrush>();
		timerText = GetComponent<TextMesh>();
        startTime = timer;
	}
	// Update is called once per frame
	void Update () {

		if(srscript.rushbar <= 0){
			Application.LoadLevel("death_Screen");
		}

	}
	// inventory function array
	//void CheckInvetory (){
	//	string[] inventory = new string[5] {
	//		"GumGun", "WaterPistol", "sleageHammer"
	//	};
	//	foreach(string items in inventory){
	//		Debug.Log(items);
	//	}
	//}

}