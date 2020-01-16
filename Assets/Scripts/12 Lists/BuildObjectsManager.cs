using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Challenge:
// Create a list/array of 3 gameObjects to spawn and 
// randomly spawn them to a random position on the screen 
// between -10 and 10 on X/Y when the player hits the space key.
// Every object spawned should be stored into a list called objectsCreated.
// Max of 10 objects can been spawned.
// Stop spawning, turn all objects green, and clear the list.

public class BuildObjectsManager : MonoBehaviour
{
   public List<GameObject> SpawnedObjects = new List<GameObject>();
   public GameObject[] enemyObjects = new GameObject[3];
   public static int SpawnCount { get; private set; }

   // prefabs
   public GameObject enemySphere;
   public GameObject enemyCube;
   public GameObject enemyCapsule;

   void Start()
   {
      enemyObjects[0] = enemySphere;
      enemyObjects[1] = enemyCube;
      enemyObjects[2] = enemyCapsule;
   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         if (SpawnCount == 10)
         {
            foreach (var item in SpawnedObjects)
            {
               item.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            SpawnedObjects.Clear();
            return;
         }
         else
         {
            int randomIndex = Random.Range(0, enemyObjects.Length);
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            
            float randomX = Random.Range(-10f, 10f);
            float randomY = Random.Range(-10f, 10f);
            Vector3 newPosition = new Vector3(randomX, randomY, 0);
            
            GameObject randomObject = Instantiate(enemyObjects[randomIndex], newPosition, Quaternion.identity);
            randomObject.GetComponent<MeshRenderer>().material.color = randomColor;
            
            SpawnedObjects.Add(randomObject);
            SpawnCount++;
         }

      }
   }
}
