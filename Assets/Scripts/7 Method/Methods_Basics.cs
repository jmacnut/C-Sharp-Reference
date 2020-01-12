using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_Basics : MonoBehaviour
{
   // Methods (same as functions)
   // Calls top to bottom order

   // Start is called before the first frame update
   void Start()
   {
      Debug.Log("Start()::");
      MyMethod();
      Debug.Log("After MyMethod() returns");

      Sum(4, 3);
   }

   // Update is called once per frame
   void Update()
   {
      // check for inputs in Update()
      // keep Update() code simple
   }

   private void MyMethod()
   {
      Debug.Log(" - MyMethod()::");
   }


   private void Sum(int a, int b)
   {
      Debug.Log("Sum of a + b = " + (a + b));
   }


   // Features are handled by Methods:

   private void Attack()
   {
      // all attack code here
   }

   private void PowerUp()
   {
      // all powerup code here
   }
}
