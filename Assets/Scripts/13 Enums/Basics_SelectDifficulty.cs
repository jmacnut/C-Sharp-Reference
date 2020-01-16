using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics_SelectDifficulty : MonoBehaviour
{
   public enum LevelSelector
   {
      EASY,    // default = 0
      NORMAL,  // default = 1
      HARD,    // default = 2
      EXPERT   // default = 3
   }

   // could also assign values
   //public enum LevelSelector
   //{
   //   Easy = 10,    // default = 0
   //   Normal = 20,  // default = 1
   //   Hard = 30,    // default = 2
   //   Expert = 40   // default = 3
   //}

   // creates a drop down in the inspector
   public LevelSelector currentLevel;

   private void Start()
   {
      switch (currentLevel)
      {
         case LevelSelector.EASY:
            Debug.Log("You selected EASY");
            break;
         case LevelSelector.NORMAL:
            Debug.Log("You selected NORMAL");
            break;
         case LevelSelector.HARD:
            Debug.Log("You selected HARD");
            break;
         case LevelSelector.EXPERT:
            Debug.Log("You selected EXPERT");
            break;
         default:
            break;
      }
   }
}
