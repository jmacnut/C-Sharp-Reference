using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   // to display the enemy count
   private StaticUIManager _uiManager;

   // called by Instantiate() for enemy
   public void OnEnable()
   {
      StaticSpawnManager.enemyCount++;
      _uiManager = GameObject.Find("UI Manager").GetComponent <StaticUIManager>();
      _uiManager.UpdateEnemyCount();

      Die();
   }

   public void OnDisable()
   {
      StaticSpawnManager.enemyCount--;
      _uiManager.UpdateEnemyCount();
   }

   public void Die()
   {
      Destroy(this.gameObject, Random.Range(2, 5));
   }

}
