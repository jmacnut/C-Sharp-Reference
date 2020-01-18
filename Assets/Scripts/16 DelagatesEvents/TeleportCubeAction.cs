using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCubeAction : MonoBehaviour
{
    void Start()
    {
      // registers event
      MainTeleport.onTeleport += TeleportObject;
    }

   public void TeleportObject(Vector3 newPosition)
   {
      transform.position = newPosition;
   }

   public void OnDisable()
   {
      MainTeleport.onTeleport -= TeleportObject;
   }
}
