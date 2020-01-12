using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
   public int itemID;
   public string itemName;
   public string itemDescription;
}


public class Arrays_IterateObjects : MonoBehaviour
{
   public Item[] itemsArray = new Item[5];
   public int selectedIndex;

   // Start is called before the first frame update
   void Start()
   {
      itemsArray[0].itemID = 0;
      itemsArray[0].itemName = null;
      itemsArray[0].itemDescription = null;

      itemsArray[1].itemID = 1;
      itemsArray[1].itemName = "SWORD";
      itemsArray[1].itemDescription = "This is a magical sword";

      itemsArray[2].itemID = 2;
      itemsArray[2].itemName = "BREAD";
      itemsArray[2].itemDescription = "I can eat this";

      itemsArray[3].itemID = 3;
      itemsArray[3].itemName = "CAPE";
      itemsArray[3].itemDescription = "Wonderful looking cape";

      itemsArray[4].itemID = 4;
      itemsArray[4].itemName = "SPEAR";
      itemsArray[4].itemDescription = "It has a sharp point";

      // display all objects
      foreach (var item in itemsArray)
      {
         Debug.Log(item.itemID + " " + item.itemName + " " + item.itemDescription);
      }

   }

   // Update is called once per frame
   void Update()
   {
      // display random object in array
      if (Input.GetKeyDown(KeyCode.Space))
      {
         int randomIndex = Random.Range(0, itemsArray.Length);

         Debug.Log("Random Item Object: " + 
                   itemsArray[randomIndex].itemID + " " + 
                   itemsArray[randomIndex].itemName + " " + 
                   itemsArray[randomIndex].itemDescription);

         for (int i = 0; i < itemsArray.Length; i++)
         {
            if (itemsArray[selectedIndex].itemID == i)
            {
               Debug.Log("Selected Item Object: " + 
                         itemsArray[selectedIndex].itemID + " " +
                         itemsArray[selectedIndex].itemName + " " +
                         itemsArray[selectedIndex].itemDescription);
            }
            else
            {
               Debug.Log("Invalid Index: No such item exists.");
            }
         }
      }
   }
}
