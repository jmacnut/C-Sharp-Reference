using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Practice Lambda Expressions
// Create a delegate of type void that calculates the sum of two numbers.
// Use a lambda function to avoid declaring a dedicated method

public class LambdaMain_VoidWithParams : MonoBehaviour
{
   // Functional Delegates requires using System
   public Action<int, int> Sum;

   void Start()
   {
      // dedicated method
      //Sum = CalculateSum;
      //int sum = Sum(5, 5);
      //Debug.Log("Sum is " + sum);

      // Lambda Expression (Anonymous Function)
      Sum = (a, b) =>
      {
         var total = a + b;

         if (total < 100)
         {
            Debug.Log("Total is less than 100");
         }

         Debug.Log("Total = " + total);
      };   // delimiter required here!

      Sum(5, 2);   // use of lambda expression
   }

   // dedicated method
   //void CalculateSum(int a, int b)
   //{
   //   var total = a + b;
   //}

}
