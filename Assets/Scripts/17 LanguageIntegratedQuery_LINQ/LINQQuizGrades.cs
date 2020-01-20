using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQQuizGrades : MonoBehaviour
{
   //public int[] quizGrades = { 44, 55, 32, 77, 95, 99, 88 };
   public int[] quizGrades = new int[10];

   // Start is called before the first frame update
   void Start()
   {
      for (int i = 0; i < quizGrades.Length; i++)
      {
         quizGrades[i] = Random.Range(0, 100);
      }

      var passingGrades = quizGrades.Where(qg => qg > 69);

      foreach (var grade in passingGrades)
      {
         Debug.Log("Passing Grade (> 69) = " + grade);
      }

   }

}
