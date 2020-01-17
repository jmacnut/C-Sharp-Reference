using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Polymorphism
// Ray Casting Code

public class UHSMaiGeneric : MonoBehaviour
{
   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         // casts ray from mouse to object

         Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hitInfo;

         if (Physics.Raycast(rayOrigin, out hitInfo))
         {
            // works, but what if many objects?
            //if (hitInfo.collider.name == "UHSPlayer")
            //{
            //   hitInfo.collider.GetComponent<UHSPlayer>().Damage(100);
            //}
            //else if (hitInfo.collider.name == "UHSEnemy")
            //{
            //   hitInfo.collider.GetComponent<UHSEnemy>().Damage(100);
            //}

            // include all objects
            IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();

            if (obj != null)
            {
               obj.Damage(500);
            }
         }
      }
   }
}
