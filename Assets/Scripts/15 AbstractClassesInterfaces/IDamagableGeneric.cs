using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generic Type Interfaces - like a contract
// Naming convention: "I" + term + "able"
// Interfaces do not inherit anything, but can implement multiple interfaces
// Cannot have public or private fields - assunes everything is public
// Cannot contain fields or attributes, 
//   but can contain properties and method signatues, only (no implementations)
// Implementor must implement all properties and methods of the interface

// Generic Type Interface for a Universal Health System
//public interface IDamagableGeneric<PrimitiveTypes>
public interface IDamagableGeneric<PrimitiveType>
//public interface IDamagableGeneric<T>
{
   float Health { get; set; }

   // polymorphism - same method accommodates diff parameter types
   //void Damage(int damageAcount);      // for UHSPlayer
   //void Damage(float damageAmount);    // for UHSEnemy

   // instead of requiring all impementers to accommodate both methods above
   // use generics
   //void Damage(PrimitiveTypes damageAmount);
   void Damage(PrimitiveType damageAmount);
   //void Damage(T damageAmount);

}
