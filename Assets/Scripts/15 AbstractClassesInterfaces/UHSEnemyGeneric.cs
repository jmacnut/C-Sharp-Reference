using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// specifies generic argument for IDamagable<T>
//public class UHSEnemyGeneric : MonoBehaviour, IDamagable<GameObject>, IShootable
public class UHSEnemyGeneric : MonoBehaviour, IDamagableGeneric<float>
{
   public float Health { get; set; } = 2000f;

   //public void Damage(GameObject damageAmount)
   public void Damage(float damageAmount)
   {
      Health -= (float) damageAmount;

      Color newColor = new Color(Random.value, Random.value, Random.value);
      GetComponent<MeshRenderer>().material.color = newColor;
   }

}
