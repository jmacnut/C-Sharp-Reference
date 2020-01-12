using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays_ForeachLoop : MonoBehaviour
{
   public string[] itemName = new string[] { "bread", "gold", "sword", "dagger", "poison spear", "cape", "cow hide", "raw hide", "flax", "chissel" };

   // Start is called before the first frame update
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         // foreach works only on collections
         // var is a universal data type
         foreach (var item in itemName)
         {
            Debug.Log(" Name: " + item);
         }
      }
   }
}
