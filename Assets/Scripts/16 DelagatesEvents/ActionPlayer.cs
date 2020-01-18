using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Actions
// Combines delegate signature and static event declarations into a single action
// requires System namespace
public class ActionPlayer : MonoBehaviour
{
   // long way
   //public delegate void OnDamageReceived(int currentHealth);   // delegate declaration
   //public static event OnDamageReceived onDamageReceived;      // subscribe to this event

   // ex. shortcut one-liner with System namespace - the following 3 are equivalent:
   //public delegate void OnComplete();
   //public Action<> onComplete;
   //public Action onComplete;
   public static Action<int> OnDamageReceived;

   public int Health { get; set; }

   void Start()
    {
      Health = 10;
    }

   void Damage()
   {
      Health--;

      // Problem: Player has to know about the UIManager
      //Solution: Have UIManager subscribe to when the Player gets damaged event
      //ActionUIManager.UpdateHealth(Health);

      //if (onDamageReceived != null)
      //{
      //   onDamageReceived(Health);
      //}

      if (OnDamageReceived != null)
      {
         OnDamageReceived(Health);
      }
   }
}
