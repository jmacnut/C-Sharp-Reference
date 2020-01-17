using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interfaces - like a contract
// Naming convention: "I" + term + "able"
// Interfaces do not inherit anything, but can implement multiple interfaces
// Cannot have public or private fields - assunes everything is public
// Cannot contain fields or attributes, 
//   but can contain properties and method signatues, only (no implementations)
// Implementor must implement all properties and methods of the interface

// Interface for a Universal Health System
public interface IDamagable
{
   int Health { get; set; }

   // polymorphism - same method accommodates diff parameter types
   // see generics for better implementation

   void Damage(int damageAcount);      // for UHSPlayer

   void Damage(float damageAmount);    // for UHSEnemy
}
