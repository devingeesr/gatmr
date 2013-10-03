using UnityEngine;
using System.Collections;

public class Sugarrush : MonoBehaviour {

    public float rushbar = 60f;
    float startTime;
    TextMesh rushText;

    // Use this for initialization
    void Start () {
        rushText = GetComponent<TextMesh>();
        startTime = rushbar;
    }
    // Update is called once per frame
    void Update () {
        if (rushbar > 0f)
        rushbar -= Time.deltaTime;
        rushText.text = rushbar.ToString("0.0");
    }
    void OnGUI() {
        //paramaters are position, width, height, title
        GUI.Box(new Rect(10, 10, (Screen.width * (rushbar) / startTime) / 3,  20), "rushbar");
    }
}