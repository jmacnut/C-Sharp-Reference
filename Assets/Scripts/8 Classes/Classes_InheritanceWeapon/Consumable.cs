using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// consumables: foods (added health) 
// class inherits/extends from Item class

[System.Serializable]
public class Consumable : Item
{
   public int addedHealth;
   public bool isPoison;

   private void Start()
   {

   }

   private void Update()
   {

   }
}
