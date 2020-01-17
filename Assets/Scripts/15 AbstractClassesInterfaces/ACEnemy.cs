using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract Classes - cannot be instantiated

public abstract class ACEnemy : MonoBehaviour
{
   public int speed;
   public int health;
   public int gems;

   // abstract method obligates implementation by inheritor
   // signature only, no {} implementation
   public abstract void Attack();

   public virtual void Die()
   {
      Destroy(this.gameObject);
   }
}

public class MossGiant : ACEnemy
{
   private void Start()
   {
      //Attack();
   }

   // must implement (override) Attack() since ACEnemy specifies it as abstract
   public override void Attack()
   {

   }

   public override void Die()
   {
      // can include code for custom particles
      base.Die();
      {

      }
   }
}