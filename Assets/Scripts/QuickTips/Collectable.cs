using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
   // Requires:
   //   Box Collider - Is Trigger = True and 
   //   Rigid Body - Use Gravity = True

   private void OnTriggerEnter(Collider other)
   {
      if(other.tag == "Player")
      {
         // add points
         // add powerup ability
         // etc.

         Destroy(this.gameObject);
         Debug.Log("Powerup Destroyed");
      }
   }
}