using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallbackMain : MonoBehaviour
{

   void Start()
   {
      // paass a lambda expression
      // void delegate with no parameters
      StartCoroutine(MyRoutine( () =>
      {
         Debug.Log("Routine Finished!");
         Debug.Log("Wow this is cool!");
      }));
   }

   // passing an anonymous routine using an action
   public IEnumerator MyRoutine(Action onComplete = null)
   {
      yield return new WaitForSeconds(5.0f);

      if (onComplete != null)
         onComplete();

      //Debug.Log("Routine Finished!");
   }
}
