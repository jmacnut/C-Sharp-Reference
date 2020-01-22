using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//User interaction
public class UserClick : MonoBehaviour
{
   void Start()
   {

   }

   void Update()
   {
      // left click
      if (Input.GetMouseButtonDown(0))
      {
         // rayOrigin is the current mouse position
         Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hitInfo;

         if (Physics.Raycast(rayOrigin, out hitInfo))
         {
            if (hitInfo.collider.tag == "Cube")
            {
               // execute the click command to assign a random color
               ICommand click = new ClickCommand(hitInfo.collider.gameObject, 
                  new Color(Random.value, Random.value, Random.value));
               click.Execute();
               CommandManager.Instance.AddToCommandBuffer(click);
            }
         }
      }
      // cast a ray
      // detect a cube
      // assign a random color
   }
}
