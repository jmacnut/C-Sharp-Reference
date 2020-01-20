using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQQuerySyntax : MonoBehaviour
{
   // specify the data source
   int[] scores = new int[] { 97, 92, 81, 60 };

   void Start()
   {
      // define the query syntax expression
      var scoreQuerySyntax =
          from score in scores
          where score > 80
          select score;   // must include this line!
      
      foreach (var score in scoreQuerySyntax)
      {
         Debug.Log("Score: " + score);
      }

      // method syntax expression
      var scoreMethodSyntax = scores.Where(score => score > 80);

      foreach (var score in scoreMethodSyntax)
      {
         Debug.Log("Score: " + score);
      }
   }


}
