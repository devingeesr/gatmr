using System;
using UnityEngine;
 
public class Pause : MonoBehaviour
{
    bool paused = false;
 
    void Update()
    {
       if(Input.GetKeyDown("escape"))
         paused = togglePause();
    }
 
    void OnGUI()
    {
       if(paused)
       {
         GUILayout.Label("Game is paused!");
         if(GUILayout.Button("Click me to unpause", GUILayout.Width(100)))
          paused = togglePause();
          if(GUILayout.Button("Directions")){
          	Application.LoadLevel("Directions");
          }
       }
    }
 
    bool togglePause()
    {
       if(Time.timeScale == 0f)
       {
         Time.timeScale = 1f;
         return(false);
       }
       else
       {
         Time.timeScale = 0f;
         return(true);    
       }
    }
}