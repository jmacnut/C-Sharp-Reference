using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SwitchDifficultyLevel : MonoBehaviour
{
   // level of difficulty
   private int _easy = 0;
   private int _medium = 1;
   private int _hard = 2;

   [SerializeField]
   private int _current;

   // Start is called before the first frame update
   void Start()
   {
      _current = Random.Range(0, 3);
   }

   // Update is called once per frame
   void Update()
   {
      switch (_current)
      {
         case 0:
            Debug.Log("Current Difficulty Level: EASY");
            break;
         case 1:
            Debug.Log("Current Difficulty Level: MEDIUM");
            break;
         case 2:
            Debug.Log("Current Difficulty Level: HARD");
            break;
         default:
            Debug.Log("Current Dicciculty Level: INVALID");
            break;
      }

      if (Input.GetKeyDown(KeyCode.Space))
      {
         _current = Random.Range(0, 3);
      }

      if (Input.GetKeyDown(KeyCode.X))
      {
         _current = 55;
      }
   }
}
