using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dictionaries are useful when working with accessing large lists

public class DItemDB : MonoBehaviour
{
   public List<DItem> itemList = new List<DItem>();

   public Dictionary<int, DItem> itemDictionary = new Dictionary<int, DItem>();

   private void Start()
   {
      //itemList.Add(new DItem());            // List
      //itemDictionary.Add(0, new DItem());   // Dictionary

      DItem sword = new DItem();
      sword.name = "Sword";
      sword.id = 0;

      DItem bread = new DItem();
      bread.name = "Bread";
      bread.id = 1;

      DItem cape = new DItem();
      cape.name = "Cape";
      cape.id = 2;

      itemDictionary.Add(0, sword);
      itemDictionary.Add(1, bread);
      itemDictionary.Add(2, cape);

      //var item = itemDictionary[0];

      // looping through key value pairs:
      foreach (KeyValuePair<int, DItem> item in itemDictionary)
      {
         Debug.Log("Key: " + item.Key + " ID: " + item.Value.id + " Value: " + item.Value.name);
      }

      // looping through the keys:
      foreach (int key in itemDictionary.Keys)
      {
         Debug.Log("Key: " + key);
      }

      // looping through the values
      foreach (DItem item in itemDictionary.Values)
      {
         Debug.Log("Item Name: " + item.name);
      }

      // check if key exists:
      if (itemDictionary.ContainsKey(60))
      {
         Debug.Log("You found the key!");
         var randomItem = itemDictionary[60];
      }
      else
      {
         Debug.Log("Key does not exist");
      }

      if (itemDictionary.ContainsKey(1))
      {
         Debug.Log("You found the key!");
         var randomItem = itemDictionary[1];
      }
      else
      {
         Debug.Log("Key does not exist");
      }
   }
}