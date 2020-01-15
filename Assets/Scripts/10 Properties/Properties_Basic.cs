using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Properties - Accessors (Getters and Setters)
// Commonly used in Game Manager class for state/status info "is___"
// Must initialize in void Start()
// Cannot be seen in inspector, unless Debug is enabled
// Also useful in Spawn Manager to report on number of enemies, for example
// Good for variables that will not be changed in inspector


public class Properties_Basic : MonoBehaviour
{
   void Start()
   {
      // transform.position can be used to get or set
      transform.position = new Vector3(0, 0, 0);

      // Time.deltaTime can only get value
      float currTime = Time.deltaTime;
   }

   // Update is called once per frame
   void Update()
   {

   }


   // Auto Properties:

   public bool IsDead { get; private set; }
   public int Score { get; private set; }

   // use IsDead() and Score in GameOver
   public void GameOver()
   {
      // test for game over
      // report score to UI
   }
}
