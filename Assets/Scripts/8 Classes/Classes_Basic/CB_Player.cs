using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// non-Monobehaviour class
public class WeaponStats
{
   public string name;
   public float fireRate;
   public int ammoCount;

   // constructor
   public WeaponStats(string name, float fireRate, int ammoCount)
   {
      this.name = name;
      this.fireRate = fireRate;
      this.ammoCount = ammoCount;
   }
}

public class CB_Player : MonoBehaviour
{
   // declare objects
   private WeaponStats blasters;
   private WeaponStats rockets;

   void Start()
   {
      // initi
      blasters = new WeaponStats("Blaster", 0.25f, 50);
      rockets = new WeaponStats("", 5f, 1);
   }

   // Update is called once per frame
   void Update()
   {

   }
}
