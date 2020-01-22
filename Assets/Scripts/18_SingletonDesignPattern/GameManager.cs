using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   private static GameManager _instance;

   public static GameManager Instance
   {
      get
      {
         if (_instance == null)
         {
            // can create on the fly (lazy instantiation) or simply inform
            Debug.LogError("The Game Manager is NULL.");
         }

         return _instance;
      }


   }

   private void Awake()
   {
      _instance = this;
   }

   public void DisplayName()
   {
      Debug.Log("My name is FirstName LastName");
   }

}
