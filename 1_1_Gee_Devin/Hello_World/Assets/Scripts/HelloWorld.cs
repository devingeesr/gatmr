using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {


	// Use this for initialization
	void Start () {

		// Changes what the guiText says
		guiText.text = "This is my title here";

		
		// Alignment of the font
		guiText.anchor = TextAnchor.MiddleCenter;
		guiText.transform.position = new Vector3(.5f, .5f, 0f);	
		
		// Adjustments and chagnes to the font
		guiText.fontStyle = FontStyle.Bold;
		guiText.fontSize = 50;
		guiText.lineSpacing = 1.5f;		
	}
	
	// Update is called once per frame
	void Update () {

	//
		guiText.color = new Color(Random.Range(0F, 1F),Random.Range(0F, 2F),Random.Range(0F, 3F));

	}
}
