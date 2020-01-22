using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lazy Instantiation

public class UIManager_LI : MonoBehaviour
{
   // private variable to declare the single instance of this class must be static
   private static UIManager_LI _instance;

   public static UIManager_LI Instance
   {
      get
      {
         if (_instance == null)
         {
            //Debug.LogError("UI Manager Instance is NULL");
            GameObject newGameObject = new GameObject("UI Manager");
            newGameObject.AddComponent<UIManager_LI>();
            Debug.Log("Created new UI Manager");
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
