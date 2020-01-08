using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
   // calculate the average of 5 random quiz grades
   [SerializeField]
   private float[] _quizGrade;

   [SerializeField]
   private float _avgGrade;

    // Start is called before the first frame update
    void Start()
    {
      // generate 5 random quiz grades and
      // calcualte the average quiz grades
      // Mathf.Round() * 100f / 100f to round to 2 decimal places
      float total = 0;

      for (int i = 0; i < _quizGrade.Length; i++)
      {
         _quizGrade[i] = Mathf.Round(Random.Range(0.0f, 100.0f) * 100f) / 100f;
         total += _quizGrade[i];
      }
      _avgGrade = Mathf.Round(total / _quizGrade.Length * 100f) / 100f;

      // print the average quiz grade
      Debug.Log("Average Grade = " + _avgGrade);

    }

}
