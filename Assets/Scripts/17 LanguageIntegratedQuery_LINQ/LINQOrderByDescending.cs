using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// Descending Order and Reverse Order

public class LINQOrderByDescending : MonoBehaviour
{
   public int[] quizGrades = { 44, 55, 32, 77, 95, 99, 88 };
   //public int[] quizGrades = new int[10];

   void Start()
   {
      //for (int i = 0; i < quizGrades.Length; i++)
      //{
      //   quizGrades[i] = Random.Range(0, 100);
      //}

      var passingGrades = quizGrades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();

      foreach (var grade in passingGrades)
      {
         Debug.Log("Passing Grade (> 69) = " + grade);
      }
   }

   // Update is called once per frame
   void Update()
   {

   }
}
