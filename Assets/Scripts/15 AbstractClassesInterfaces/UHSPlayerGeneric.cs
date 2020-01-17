using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// specifies generic argument for IDamagable<T>
public class UHSPlayerGeneric : MonoBehaviour, IDamagableGeneric<int>, IShootable
{
   public float Health { get; set; } = 2000f;

   public void Damage(int damageAmount)
   {
      Health -= (float) damageAmount;

      Color newColor = new Color(Random.value, Random.value, Random.value);
      GetComponent<MeshRenderer>().material.color = newColor;
   }

   public void Shoot()
   {

   }

}
