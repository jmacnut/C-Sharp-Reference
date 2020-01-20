using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// Language Integrated Query
// SQL for Arrays and Lists
// Requires: using System.Linq; namespace

public class LINQExample : MonoBehaviour
{
   public string[] names = { "jon", "alex", "julie", "jessie", "david", "mark", "matt" };

   void Start()
   {
      // one-liner using LINQ
      // like an in-line foreach loop using a lambda expression
      //var nameFound = names.Any(name => name == "job");   // false
      var nameFound = names.Any(name => name == "jon");

      Debug.Log("Name Found: " + nameFound);

      // non-LINQ way
      //foreach (var name in names)
      //{
      //   if (name == "jon")
      //   {
      //      Debug.Log("Found Jon!");
      //   }
      //}
   }


   void Update()
   {

   }
}
