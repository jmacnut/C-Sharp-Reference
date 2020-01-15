using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Utility Helper Classes
// Static classes available to all projects
// Static classes cannot inherit MonoBehaviour
// Static classes cannot inherit other classes
// All methods and variables need to be static

public class UtilityHelper
{
   public static void CreateObject()
   {
      // create a new primitive cube
      GameObject.CreatePrimitive(PrimitiveType.Cube);
   }

   public static void ResetPositionToZero(GameObject obj)
   {
      // reset position of obj to zero
      obj.transform.position = Vector3.zero;
   }
}
