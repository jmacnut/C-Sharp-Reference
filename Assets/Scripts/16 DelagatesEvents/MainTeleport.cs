using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTeleport : MonoBehaviour
{
   // delegate declaration signature
   public delegate void TeleportAction(Vector3 newPosition);

   // declare event
   public static event TeleportAction onTeleport;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         // any subscribers?
         if (onTeleport != null)
         {
            Vector3 pos = new Vector3(5f, 2f, 0);

            // invoke event and notify all subscribers
            onTeleport(pos);
         }
      }
   }
}
