using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   // assign in inspector
   public GameObject enemyPrefab;

   // static var to display in the UI
   public static int enemyCount;

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Instantiate(enemyPrefab);
      }
   }


}
