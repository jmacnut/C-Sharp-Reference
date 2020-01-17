﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UHSPlayer : MonoBehaviour, IDamagable, IShootable
{
   public int Health { get; set; } = 2000;

   public void Damage(int damageAmount)
   {
      Health -= damageAmount;

      Color newColor = new Color(Random.value, Random.value, Random.value);
      GetComponent<MeshRenderer>().material.color = newColor;
   }

   public void Damage(float damageAmount)
   {

   }
   public void Shoot()
   {

   }

}
