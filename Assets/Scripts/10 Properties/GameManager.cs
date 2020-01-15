using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Properties - Accessors (Getters and Setters)
// Ability to run and initialize code via a variable

// Note: cannot see properties in the inspector unless in Debug Mode
// Enable Debug Mode with the vertical elipses icon (upper right of inspector)
// and select Debug

public class GameManager : MonoBehaviour
{
   // declare a property - but do not want to do this
   //public bool isGameOver;

   // do not want to do this
   //public void GameOver()
   //{
   //   isGameOver = true;
   //   // call UI Manager and enable the game over screen
   //}

   // instead, do this, plus additional function code
   //private bool isGameOver;

   //// property
   //public bool IsGameOver
   //{
   //   get
   //   {
   //      return isGameOver;
   //   }

   //   set
   //   {
   //      if (value == true)
   //      {
   //         // post to UI Manager
   //         Debug.Log("Oh, no!  The game is over!");
   //      }
   //      // trigger reset scene
   //      isGameOver = value;
   //   }
   //}


   // or use Auto Property if no additional code required
   // read-only outside of this script
   public bool IsGameOver { get; private set; }

   // if using for inheritance
   //public bool IsGameOver { get; protected set; }



   void Start()
   {
      // property defined with additional code
      // only place where var can be changed
      //isGameOver = false;

      // auto-property declared
      IsGameOver = false;
   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         // utilizes setter
         IsGameOver = true;
      }
   }
}
