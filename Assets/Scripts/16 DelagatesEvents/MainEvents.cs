using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Events
// A type of delegate that enables creation of a broadcast/notification system
// that allows other classes/objects to subscribe or de-subscribe to a common 
// event.
// Objects don't know about eachother
// Events have inherent security vs just delegates
// Alternative to for loop running in a main script on a multitude of objects

public class MainEvents : MonoBehaviour
{
   // turns 3 cubes red and drops a sphere when a button is pressed (event)

   public delegate void ActionClick();
   public static event ActionClick onClick;
    
   public void ButtonClick()
   {
      // verify there are listeners available
      if (onClick != null)
      {
         onClick();
      }

   }
}
