using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// spawn manager singleton class
public class MSSpawnManager : MonoBehaviour
{
   // create the instance
   private static MSSpawnManager _instance;

   // create public single object
   public static MSSpawnManager Instance
   {
      get
      {
         if (_instance == null)
         {
            //Debug.LogError("Spawn Manager instance is NULL");
            GameObject go = new GameObject("Spawn Manager");
            go.AddComponent<MSSpawnManager>();
         }

         return _instance;
      }
   }

   private void Awake()
   {
      _instance = this;
   }

   [SerializeField]
   private GameObject _enemyPrefab;

   public void StartSpawning()
   {
      Debug.Log("Spawn Started");
      Instantiate(_enemyPrefab);
   }

   private void Start()
   {
      Debug.Log(MSPlayer.Instance.name);
   }
}
