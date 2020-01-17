using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Polymorphism
// Ray Casting Code

public class UHSMainGeneric : MonoBehaviour
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
            //if (hitInfo.collider.name == "UHSPlayerGeneric")
            //{
            //   hitInfo.collider.GetComponent<UHSPlayerGeneric>().Damage(100);
            //}
            //else if (hitInfo.collider.name == "UHSEnemyGeneric")
            //{
            //   hitInfo.collider.GetComponent<UHSEnemyGeneric>().Damage(100f); // ?? problem ??
            //}

            //accounts for multiple objects but doesn't call Damage(), why ??
            //IDamagableGeneric<Object> genObj = hitInfo.collider.GetComponent<IDamagableGeneric<Object>>();
            //IDamagableGeneric<PrimitiveTypes> genObj = hitInfo.collider.GetComponent<IDamagableGeneric<PrimitiveTypes>>();
            IDamagableGeneric<PrimitiveType> genObj = hitInfo.collider.GetComponent<IDamagableGeneric<PrimitiveType>>();
            //IDamagableGeneric<T> genObj = hitInfo.collider.GetComponent<IDamagableGeneric<T>();
            if (genObj != null)
            {
               //genObj.Damage(500);
               //genObj.Damage(500f);
               //genObj.Damage((UnityEngine.PrimitiveType)500f);
               //genObj.Damage((UnityEngine.PrimitiveTypes)500f);
               //genObj.Damage((PrimitiveTypes)500);
               genObj.Damage((PrimitiveType)500f);
            }
         }
      }
   }
}
