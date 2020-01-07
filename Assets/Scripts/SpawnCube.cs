using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
   [SerializeField]
   private GameObject cubePrefab;

   // Start is called before the first frame update
   void Start()
   {
      if (cubePrefab != null)
      {
         //cubePrefab = new GameObject<Cube>();
      }
   }

   // Update is called once per frame
   void Update()
   {

      if (Input.GetKeyDown(KeyCode.Space))
      {
         // Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);   // no rotation at (0, 0, 0)
         Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(45,45, 0));

      }

   }
}
