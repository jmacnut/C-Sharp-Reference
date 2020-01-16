using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLists : MonoBehaviour
{
   // List (dynamic)
   public List<GameObject> enemiesToSpawn = new List<GameObject>();

   // Array
   public GameObject[] objectsToSpawn = new GameObject[5];


   void Start()
   {
      // List
      //enemiesToSpawn.Add(new GameObject);
      enemiesToSpawn[2].name = "Kylo Ren";

      //accessed the same way
      objectsToSpawn[2].name = "Me";
   }

}
