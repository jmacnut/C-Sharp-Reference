using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionUIManager : MonoBehaviour
{
   private void OnEnable()
   {
      //ActionPlayer.onDamageReceived += UpdateHealth;
      ActionPlayer.OnDamageReceived += UpdateHealth;
   }

   public void UpdateHealth(int health)
   {
      // display updated health here
      Debug.Log("Current Health: " + health);
      //ActionPlayer.Health = health;
   }

   private void OnDisable()
   {
      ActionPlayer.OnDamageReceived -= UpdateHealth;
   }
}
