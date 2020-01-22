using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Challenge:
// turn this class into a singleton for easy accessibility
// pre-generate a list of bullets using the bullet prefab

public class BulletPoolManager : MonoSingleton<BulletPoolManager>
{
   private static BulletPoolManager _instance;
   public static BulletPoolManager Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.LogError("The Pool Manager is NULL.");
         }

         return _instance;
      }
   }

   private void Awake()
   {
      _instance = this;
   }


   [SerializeField]
   private GameObject _bulletContainer;

   [SerializeField]
   private GameObject _bulletPrefab;

   [SerializeField]
   private List<GameObject> _bulletPool;

   private void Start()
   {
      _bulletPool = GenerateBullets(10);  // about 12 is max
   }

   // pregenerate a list of bulelts using the bullet prefab
   private List<GameObject> GenerateBullets(int amt)
   {

      for (int i = 0; i < amt; i++)
      {
         GameObject bullet = Instantiate(_bulletPrefab);
         bullet.transform.parent = _bulletContainer.transform;
         bullet.SetActive(false);
         _bulletPool.Add(bullet);
      }

      return _bulletPool;
   }

   public GameObject RequestBullet()
   {
      // loop through the bullet list
      // checking for in-active bullet
      // found one? set it active and return it to the player
      foreach (var bullet in _bulletPool)
      {
         if (bullet.activeInHierarchy == false)
         {
            // bullet is available
            bullet.SetActive(true);
            return bullet;

         }
      }

      // if we made it to this point...need to generate a new bullet:
      GameObject newBullet = Instantiate(_bulletPrefab);
      newBullet.transform.parent = _bulletContainer.transform;
      //newBullet.SetActive(true);   // default
      _bulletPool.Add(newBullet);

      return newBullet;

   }
}
