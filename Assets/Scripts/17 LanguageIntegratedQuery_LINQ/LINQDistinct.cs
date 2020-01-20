using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// Distinct removes duplicate elements in a collection
public class LINQDistinct : MonoBehaviour
{
   public string[] names = { "jon", "jon", "julie", "alex", "julie", "jessie", "david", "mark", "matt" };

   void Start()
    {
      var uniqueNames = names.Distinct();

      foreach (var name in uniqueNames)
      {
         Debug.Log("Name: " + name);
      }
   }


   void Update()
    {
        
    }
}
