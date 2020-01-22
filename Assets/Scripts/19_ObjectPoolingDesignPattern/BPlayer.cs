using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlayer : MonoBehaviour
{
   [SerializeField]
   private GameObject _bulletPrefab;
    
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         //Instantiate(_bulletPrefab);   // must re-use bullets
         // communicate with the object pool system
         // request bullet
         GameObject bullet = BulletPoolManager.Instance.RequestBullet();
         bullet.transform.position = Vector3.zero;

      }
   }
}
