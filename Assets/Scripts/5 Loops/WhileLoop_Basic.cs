using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop_Basic : MonoBehaviour
{
   // infinite loop in Start or Update will freeze execution
   // while(true) {}

   // specify proper termination condition or
   // use coroutines for proper infinite loop execution

   public int apples;

   // Start is called before the first frame update
   void Start()
   {
      while (apples < 50)
      {
         Debug.Log("Apples = " + apples);
         apples++;
      }
   }

   // Update is called once per frame
   void Update()
   {

   }
}
