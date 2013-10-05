using UnityEngine;
using System.Collections;

public class Gamefunctions : MonoBehaviour {

	// varable to use for accessing the sugarrush script
	private Sugarrush srscript;

	public float timer = 60f;
    public float startTime;

	// Use this for initialization
	void Start () {
		srscript	= gameObject.GetComponent<Sugarrush>();
        startTime	= timer;
	}
	// Update is called once per frame
	void Update () {

	}
    void OnGUI () {

    }
}