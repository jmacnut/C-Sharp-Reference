using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Func - Function Delegates are Return Type Delegates
// vs void type delegate (previously covered)

// Explore 3 ways:
// 1) no delegate
// 2) return type delegate
// 3) func delegate

// A program that takes a string argument and returns the number of chars
public class FuncMain : MonoBehaviour
{
   // void return type delegate ex:
   //public delegate void OnComplete();
   // return type delegate ex:
   //public delegate string OnComplete();

   // 2) return type delegate
   //public delegate int CharacterLength(string someText);
   //CharacterLength cl;

   // 3) functional delegates using Func<parameter, return value>
   // requires using System;)
   public Func<string, int> CharacterLength;

   private void Start()
   {
      // 1) return type function
      //int charCount = GetCharCount("Golden");
      //Debug.Log("Character Count = " + charCount);

      // 2) return type delegate
      //cl = GetCharCount;
      ////cl = new CharacterLength(GetCharCount);

      //// code
      //// code
      //// code

      //Debug.Log(cl("Golden"));

      // 3) functional delegates using Func<parameter, return value>
      CharacterLength = GetCharCount;   // subscribe
      int count = CharacterLength("Golden");

      Debug.Log("Character Count = " + count);

   }

   int GetCharCount(string wotd)
   {
      return wotd.Length;
   }

}
