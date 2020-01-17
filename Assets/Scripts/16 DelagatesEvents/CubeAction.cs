using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach this script to each cube
// self contained (does not depend on other objects)

public class CubeAction : MonoBehaviour
{
    // subscribe to onClick() event
    void Start()
    {
      // registers TurnRed() to each cube's onClick() event 
      MainEvents.onClick += TurnRed;   // subscribes
    }

   public void TurnRed()
   {
      GetComponent<MeshRenderer>().material.color = Color.red;
   }

   private void OnDisable()
   {
      MainEvents.onClick -= TurnRed;  // unsubscribes
   }

}
