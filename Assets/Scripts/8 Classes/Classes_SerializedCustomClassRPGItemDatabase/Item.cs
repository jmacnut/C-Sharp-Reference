using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// blueprint custom class - does not inherit from MonoBehaviour
// no Unity behaviors necessary for descriptive (non-behavior) class template

[System.Serializable]
public class Item
{
   public string name;
   public int id;
   public string description;
   public Sprite icon;

   public Item()
   {

   }
   public Item(string name, int id, string description)
   {
      this.name = name;
      this.id = id;
      this.description = description;
   }
}

