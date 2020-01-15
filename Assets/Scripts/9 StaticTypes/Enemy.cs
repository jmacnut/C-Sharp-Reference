using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   // to display the enemy count
   private UIManager _uiManager;

   // called by Instantiate() for enemy
   public void OnEnable()
   {
      SpawnManager.enemyCount++;
      _uiManager = GameObject.Find("UI Manager").GetComponent <UIManager>();
      _uiManager.UpdateEnemyCount();

      Die();
   }

   public void OnDisable()
   {
      SpawnManager.enemyCount--;
      _uiManager.UpdateEnemyCount();
   }

   public void Die()
   {
      Destroy(this.gameObject, Random.Range(2, 5));
   }

}
