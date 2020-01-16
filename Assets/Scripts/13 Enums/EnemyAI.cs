using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Useful for FSM Finite State Machines in AI

public class EnemyAI : MonoBehaviour
{
   public enum EnemyState
   {
      Patrolling,
      Attacking,
      Chasing,
      Death
   }

   public EnemyState currentState;

   void Start()
    {
      currentState = EnemyState.Patrolling;
    }
    
    void Update()
    {
      switch (currentState)
      {
         case EnemyState.Patrolling:
            Debug.Log("Enemy State: Patrolling");
            // Patrolling Behavior
            if (Time.time > 5)
            {
               // Next state
               currentState = EnemyState.Chasing;
            }
            break;
         case EnemyState.Attacking:
            Debug.Log("Enemy State: Attacking");
            // Attacking Behavior
            if (Time.time > 20)
            {
               // Next state
               currentState = EnemyState.Death;
            }
            break;
         case EnemyState.Chasing:
            Debug.Log("Enemy State: Chasing");
            // Chasing Behavior
            if (Time.time > 15)
            {
               // Next state
               currentState = EnemyState.Attacking;
            }
            break;
         case EnemyState.Death:
            Debug.Log("Enemy State: Death");
            // Death Behavior
            // Next state = Destroy()
            break;
         default:
            break;
      }

      if (Input.GetKeyDown(KeyCode.Space))
      {

      }
   }
}
