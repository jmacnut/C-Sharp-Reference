using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Problem: in Death(), Player must know about specific GameManager and UIManager
// and does not support modularity.
// Fix: Use delegate, instead, separate from Player and to notify those who want
// to be notified

public class EDPPlayer : MonoBehaviour
{
   public delegate void OnDeath();        // delegate
   public static event OnDeath onDeath;   // event

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Death();
      }
   }

   void Death()
   {
      // specific:
      //GameObject.FindObjectOfType<EDPGameManager>().ResetPlayer();
      //GameObject.FindObjectOfType<EDPUIManager>().UpdateDeathCount();

      // generic:
      if (onDeath != null)
      {
         onDeath();
      }
   }
}