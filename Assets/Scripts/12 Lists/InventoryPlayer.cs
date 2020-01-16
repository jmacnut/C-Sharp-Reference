using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{
   public InventoryItem[] inventoryItem = new InventoryItem[10];

   private InventoryItemDB _inventoryItemDB;

   private void Start()
   {
      _inventoryItemDB = GameObject.Find("InventoryItemDB").GetComponent<InventoryItemDB>();
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.A))
      {
         // request item by ID
         _inventoryItemDB.AddItem(0, this);
      }
      else if (Input.GetKeyDown(KeyCode.R))
      {
         // remove item from inventory by ID
         _inventoryItemDB.RemoveItem(0, this);
      }
   }
}
