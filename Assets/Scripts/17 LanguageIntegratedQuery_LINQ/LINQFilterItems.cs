using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// Challenge:
// Check if Item ID = 3 exists in the list and print out true or false
// Grab all items with buff greater than 20 and print them out
// Calculate the averate of all the buff stats

[System.Serializable]
public class LINQItem
{
   public string name;
   public int id;
   public int buffStatus;

   public LINQItem(string name, int id, int buffStatus)
   {
      this.name = name;
      this.id = id;
      this.buffStatus = buffStatus;
   }

}

public class LINQFilterItems : MonoBehaviour
{
   public List<LINQItem> items;

   void Start()
   {
      items.Add(new LINQItem("Sword", 1, 50));
      items.Add(new LINQItem("Bread", 2, 5));
      items.Add(new LINQItem("Staff", 3, 15));
      items.Add(new LINQItem("Arrow", 4, 25));
      items.Add(new LINQItem("Feather", 5, 6));

      var idFound = items.Any(Item => Item.id == 3);
      if (idFound == true)
      {
         Debug.Log("Item with ID = 3 exists!");
      }

      var largeBuff = items.Where(item => item.buffStatus > 20);
      foreach (var item in largeBuff)
      {
         Debug.Log("Item Buff Status: ID: " + item.id + " Name: " + item.name + " Buff Stat: " + item.buffStatus);
      }

      var buffAvg = items.Average(item => item.buffStatus);
      Debug.Log("Buff Stats Avg = " + buffAvg);

   }

   void Update()
   {

   }
}
