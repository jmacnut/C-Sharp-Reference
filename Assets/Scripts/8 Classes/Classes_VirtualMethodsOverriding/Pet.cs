using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// inheriting from MonoBehaviour
// provides access to Unity behaviors
public class Pet : MonoBehaviour
{
   protected string petName;

   // allows child class override
   // child class must use same access modifier as base class
   protected virtual void Speak()
   {
      Debug.Log("Speak!");
   }

   // inheriting from MonoBehaviour provides access to methods
   private void Start()
   {
      Speak();  // virtual method checks executes override methods in children
   }
}
