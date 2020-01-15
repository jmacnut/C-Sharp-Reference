using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// inheritance - extending Item class

[System.Serializable]
public class Weapon : Item
{
   public int attackBonus;
   public int prayerBonus;
   public int strengthBonus;
   public int MageBonus;

   private void Start()
   {

   }

   private void Update()
   {

   }

   void MyMethod()
   {
      // inherited/extended class vars are readily accessible
      this.name = "";
      this.id = 1;
      //this.icon = ...;
   }
}
