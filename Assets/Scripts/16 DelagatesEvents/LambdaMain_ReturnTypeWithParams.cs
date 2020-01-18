using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaMain_ReturnTypeWithParams : MonoBehaviour
{
   /// <summary>
   /// Create a delegate of type int that takes 2 numbers as a parameter 
   /// determines their sum
   /// </summary>

   public Func<int, int, int> onCalculateSum;

   private void Start()
   {
      //onCalculateSum = (a, b) => a + b;
      onCalculateSum = (a, b) =>
      {
         // additional code
         return a + b;
      };

      var total = onCalculateSum(6, 7);

      Debug.Log("Sum = " +total); 
   }


   //int CalculateSum(int a, int b)
   //{
   //   return a + b;
   //}
}
