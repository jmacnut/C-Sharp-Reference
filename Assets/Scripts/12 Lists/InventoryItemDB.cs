using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemDB : MonoBehaviour
{
   public List<InventoryItem> inventoryItems = new List<InventoryItem>();

   public void AddItem(int itemID, InventoryPlayer inventoryPlayer)
   {
      // check if item matches something in the database
      foreach (var item in inventoryItems)
      {
         // check for match
         if (item.id == itemID)
         {
            Debug.Log("We have a match!");

            // check for acailable inventory slots
            inventoryPlayer.inventoryItem[0] = item;
            return;
         }
      }
      Debug.Log("Item does not exist!");
   }

   public void RemoveItem(int itemID, InventoryPlayer inventoryPlayer)
   {
      foreach (var item in inventoryItems)
      {
         if (item.id == itemID)
         {
            // we have a match
            inventoryPlayer.inventoryItem[0] = null;
         }
      }
   }
}
