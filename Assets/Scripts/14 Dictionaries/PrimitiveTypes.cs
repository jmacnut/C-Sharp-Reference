using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitiveTypes : MonoBehaviour
{
   //public Dictionary<string, int> people = new Dictionary<string, int>();

   //private void Start()
   //{
   //   people.Add("JJ", 26);
   //   people.Add("Rey", 55);
   //   people.Add("Han", 31);
   //   people.Add("Paige", 34);

   //   int hansAge = people["Han"]; // returns 31
   //   Debug.Log("Han's Age is " + hansAge);
   //}

   public Dictionary<int, string> books = new Dictionary<int, string>();

   private void Start()
   {
      books.Add(0, "The Ultimate Guide to Game Development with Unity");
      books.Add(1, "The Unity C# Survival Guide");

      //Debug.Log("Book [1]: " + books[1]);

      foreach (KeyValuePair<int, string> book in books)
      {
         Debug.Log("Book: " + book.Value + " [ID = " + book.Key + "]");
      }

      foreach (string title in books.Values)
      {
         Debug.Log("Title: " + title);
      }
      
      foreach (int num in books.Keys)
      {
         Debug.Log("Key: " + num);
      }
   }
}
