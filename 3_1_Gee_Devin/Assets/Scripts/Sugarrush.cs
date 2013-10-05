using UnityEngine;
using System.Collections;

public class Sugarrush : MonoBehaviour {

    public float rushbar = 60f;
    float startTime;

    // Use this for initialization
    void Start () {
        startTime = rushbar;
    }
    // Update is called once per frame
    void Update () {
        if (rushbar > 0f)
        rushbar -= Time.deltaTime;
    }
    void OnGUI() {
        //paramaters are position, width, height, title
        GUI.Box(new Rect(10, 20, (Screen.width * (rushbar) / startTime) / 3,  20), "rushbar");
    }
}