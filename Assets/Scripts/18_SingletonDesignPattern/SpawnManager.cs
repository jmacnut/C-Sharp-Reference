using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// spawn manager singleton class
public class SpawnManager : MonoBehaviour
{
   // create the instance
   private static SpawnManager _instance;

   // create public single object
   public static SpawnManager Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.LogError("Spawn Manager instance is NULL");
         }

         return _instance;
      }
   }

   private void Awake()
   {
      _instance = this;
   }

   public void StartSpawning()
   {
      Debug.Log("Spawn Started");
   }
}
