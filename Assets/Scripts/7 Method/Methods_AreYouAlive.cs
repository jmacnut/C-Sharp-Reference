using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// check if the player is dead or alive
// space key damages the player by a random amount
// if the player is dead (health < 1), print out "The player has died!"
// Bonus: prevent the damage function from being called once player is dead and 
//        no negative health values

public class Methods_AreYouAlive : MonoBehaviour
{
   public int health;
   public int randomDamageAmt;

   // Start is called before the first frame update
   void Start()
   {
      health = 100;
   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space) && !IsDead())
      {
         //if (PlayerIsDead() == true)
         randomDamageAmt = Random.Range(5, 20);
         Damage(randomDamageAmt);
      }

   }

   public void Damage(int damageAmt)
   {
      health -= damageAmt;

      // if (IsDead())
      if (IsDead() == true)
      {
         health = 0;
         Debug.Log("The Player est Morte!");
      }
   }

   public bool IsDead()
   {
      return health < 1;
   }
}
