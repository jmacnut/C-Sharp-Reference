using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Pet
{
   // overrides base class method
   // overriding method must use same access modifier as base class
   protected override void Speak()
   {
      //base.Speak();   // base class Speak() method
      Debug.Log("Quack Quack!");
   }
}
