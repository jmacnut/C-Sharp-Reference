using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reminder: using System

public class LambdaMain_VoidWithNoParams : MonoBehaviour
{
   /// <summary>
   // Create a delegate of type void that has no parameters and returns the 
   // gameObject's name
   /// </summary>

   public Action OnGetName;

   private void Start()
   {
      //OnGetName = () => Debug.Log("Object Name: " + gameObject.name);

      OnGetName = () =>
      {
         Debug.Log("Object Name: " + gameObject.name);
         // more code...
      };


      OnGetName();
   }


   //void GetName()
   //{
   //   Debug.Log("Name " + gameObject.name);
   //}
}
