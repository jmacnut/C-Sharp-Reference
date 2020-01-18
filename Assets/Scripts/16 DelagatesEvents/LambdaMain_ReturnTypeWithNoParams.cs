using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaMain_ReturnTypeWithNoParams : MonoBehaviour
{
   /// <summary>
   /// Create a delegate of type int that returns the length of the gameObject's name
   /// </summary>

   public Func<int> onGetName;

   private void Start()
   {
      onGetName = () => this.gameObject.name.Length;
      int charCount = onGetName();

      Debug.Log("Char Count = " + charCount);
   }

   //int GetName()
   //{
   //   return this.gameObject.name.Length;
   //}
}
