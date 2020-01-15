using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
   public Spell[] spells;

   public int level;
   public int exp;   // experience level


   private void Start()
   {
      //spells = new Spell[2];
      //fireBlast = new Spell("Fire Blast", 1, 27, 35);
      //spells[0] = new Spell("Fire Blast", 1, 27, 35);
      //iceBlast = new Spell("Ice Blast", 3, 29, 55);
      //spells[1] = new Spell("Ice Blast", 3, 29, 55);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         // iterate through the spell list and compare current level
         // cast spell

         foreach (var spell in spells)
         {
            if (spell.levelRequired == level)
            {
               spell.Cast();
               exp += spell.expGained;
            }
         }
      }
   }

}
