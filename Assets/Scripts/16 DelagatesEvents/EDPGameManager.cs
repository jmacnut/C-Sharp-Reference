using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDPGameManager : MonoBehaviour
{
   private void OnEnable()
   {
      EDPPlayer.onDeath += ResetPlayer;     
   }

   public void ResetPlayer()
   {
      Debug.Log("Resetting Player");
   }

   private void OnDisable()
   {
      EDPPlayer.onDeath -= ResetPlayer;
   }
}
