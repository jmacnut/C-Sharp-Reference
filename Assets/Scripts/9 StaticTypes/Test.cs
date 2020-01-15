using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   // static implementation
   // access class variable directly

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         // add 10 to score;
         Score.score += 10;

         Debug.Log("Score: " + Score.score);
      }
   }

   // non-static implementation
   // requires an instance of a class to access

   //private Score _score;

   // void Start()
   // {
   //   _score = GameObject.Find("Score Keeper").GetComponent<Score>();
   // }
   //
   // void Update()
   // {
   //   if (Input.GetKeyDown(KeyCode.Space))
   //   {
   //      // add 10 to score;
   //      _score.score += 10;
   //   }
   //}
}
