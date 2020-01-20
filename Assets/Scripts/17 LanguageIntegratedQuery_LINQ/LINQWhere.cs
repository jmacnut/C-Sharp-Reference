using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQWhere : MonoBehaviour
{
   public string[] names = { "jon", "jon", "julie", "alex", "julie", "jessie", "david", "mark", "matt", "batista" };

   void Start()
    {
      var results = names.Where(n => n.Length > 5);

      foreach (var name in results)
      {
         Debug.Log("Name: " + name);
      }
   }

   void Update()
    {
        
    }
}
