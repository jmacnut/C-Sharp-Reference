using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
         Time.timeScale = 0.0f;           // 0 = pauses the game
         Debug.Log("Paused...");
      }

      if (Input.GetKeyDown(KeyCode.S))
      {
         Time.timeScale = 0.25f;           // 0.5 = slow motion
         Debug.Log("Slow motion...");
      }

      if (Input.GetKeyDown(KeyCode.R))
      {
         Time.timeScale = 1.0f;           // 1 = default
         Debug.Log("Resume...");
      }
   }
}
