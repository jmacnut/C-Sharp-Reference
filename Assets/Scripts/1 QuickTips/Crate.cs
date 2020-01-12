using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
   public GameObject fracturedCrate;
   public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
      {
         Instantiate(explosionEffect, transform.position, Quaternion.identity);
         GameObject fracturedCrateObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity);
         Rigidbody[] allRigidBodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>();
         if(allRigidBodies.Length > 0)
         {
            foreach (var body in allRigidBodies)
            {
               body.AddExplosionForce(500f, transform.position, 1f);
            }
         }
         Destroy(this.gameObject);
      }
   }
}
