using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EItem
{
   public string name;
   public int id;
   public Sprite icon;

   public enum EItemType
   {
      None,
      Weapon,
      Consumable
   }

   public EItemType eItemType;

   public void Action()
   {
      switch (eItemType)
      {
         case EItemType.None:
            Debug.Log("EItem Type: None");
            break;
         case EItemType.Weapon:
            Debug.Log("EItem Type: Weapon");
            break;
         case EItemType.Consumable:
            Debug.Log("EItem Type: Consumable");
            break;
         default:
            break;
      }
   }
}

