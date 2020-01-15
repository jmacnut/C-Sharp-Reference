using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   public Text activeEnemiesText;

   public void UpdateEnemyCount()
   {
      activeEnemiesText.text = "Active Enemies: " + SpawnManager.enemyCount;
   }

   // avoid doing this - use singelton design pattern, instead
   //// static required to use in UpdateEnemyCount()
   //public static Text activeEnemiesText;

   //// use of static method
   //public static void UpdateEnemyCount()
   //{
   //   // use of static variable enemyCount
   //   activeEnemiesText.text = "Active Enemies: " + SpawnManager.enemyCount;

   //   // same as
   //   // UIManager.activeEnemiesText.text = "Active Enemies: " + SpawnManager.enemyCount;
   //}
}
