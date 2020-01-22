using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   // private variable to declare the single instance of this class must be static
   private static UIManager _instance;

   public static UIManager Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.LogError("UI Manager Instance is NULL");
         }

         return _instance;
      }
   }

   private void Awake()
   {
      _instance = this;
   }

   public void UpdateScore(int score)
   {
      Debug.Log("Score: " + score);

      // singleton instances can communicate with other singleton objects,
      // but not other non-singleton objects
      Debug.Log("Notifying the game manager");
      GameManager.Instance.DisplayName();
   }


}
