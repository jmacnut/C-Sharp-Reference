using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays_ForLoop : MonoBehaviour
{
   public int printID;
   public int[] itemID = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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
         for (int i = 0; i < itemID.Length; i++)
         {
            if (itemID[i] == printID)
            {
               Debug.Log("itemID: " + itemID[i] + " itemName: " + itemName[i]);
            }
         }
      }
   }
}
