using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EDPUIManager : MonoBehaviour
{
   public int deathCount;
   public Text deathCountText;

   private void OnEnable()
   {
      EDPPlayer.onDeath += UpdateDeathCount;
   }
   public void UpdateDeathCount()
   {
      deathCount++;
      deathCountText.text = "Death Count: " + deathCount;
   }

   private void OnDisable()
   {
      EDPPlayer.onDeath -= UpdateDeathCount;
   }
}
