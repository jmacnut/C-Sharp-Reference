using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQContains : MonoBehaviour
{

   public string[] names = { "jon", "alex", "julie", "jessie", "david", "mark", "matt" };

   void Start()
   {
      // one-liner using LINQ
      // like an in-line foreach loop using a lambda expression
      //var nameFound = names.Any(name => name == "job");   // false
      //var nameFound = names.Any(name => name == "jon");

      // Contains
      var nameFound = names.Contains("jon");

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
