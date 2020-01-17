using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAction : MonoBehaviour
{
    void Start()
    {
      MainEvents.onClick += Fall;
    }
    
   void Fall()
   {
      GetComponent<Rigidbody>().useGravity = true;
   }

   private void OnDisable()
   {
      MainEvents.onClick -= Fall;
   }
}
