using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Enums to Ints (Use a cast)
// Level Scene Selection Requires Integer

public class LevelSelect : MonoBehaviour
{
   public enum Difficulty
   {
      Easy,    // 0
      Normal,  // 1
      Hard,    // 2
      Expert   // 3
   }

   public Difficulty selectedDifficulty;

   private void Start()
   {
      // requires scene to be set up in the build settings
      SceneManager.LoadScene((int)selectedDifficulty);
   }
}
