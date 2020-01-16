using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EItemDB : MonoBehaviour
{
   public List<EItem> eItemDB = new List<EItem>();

   private void Start()
   {
      //eItemDB[0].Action();
      foreach (var item in eItemDB)
      {
         item.Action();
      }
   }
}
