using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lambda Expression - Defines a function in-line

// A program that takes a string argument and returns the number of chars
public class LambdaMain : MonoBehaviour
{
   public Func<string, int> StringLength;

   private void Start()
   {
      // Functional delegates using Func<parameter, return value>
      //CharacterLength = GetCharCount;   // subscribe

      // Lambda Expression
      // (parameter) => return function;
      // Lambda Operator => means "go to"

      StringLength = (someText) => someText.Length;

      int count = StringLength("Golden");

      Debug.Log("Character Count = " + count);

   }

   // turn this into a Lambda Expression
   //int GetCharCount(string wotd)
   //{
   //   return wotd.Length;
   //}

}
