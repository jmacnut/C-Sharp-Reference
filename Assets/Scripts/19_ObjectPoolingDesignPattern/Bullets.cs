using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

   private void OnEnable()
   {
      Invoke("Hide", 1);
   }

   private void Hide()
   {
      Debug.Log("Hiding GameObject");
      // recycle the game object
      this.gameObject.SetActive(false);
   }

}
