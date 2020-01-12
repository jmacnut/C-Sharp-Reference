using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_ChangePosition4Ways : MonoBehaviour
{

   // Start is called before the first frame update
   void Start()
   {
      // 1) reset Player position to center
      //transform.position = new Vector3(0, 0, 0);

      // 2) call a function
      //ResetPosition();

      // 3) change position via parameters
      // //ChangePosition(new Vector3(1f, 1f, 1f));
      //ChangePosition(Vector3.one);

      // 4) position returned by method
      transform.position = GetPosition(2f, 2f, 2f);


   }

   // Update is called once per frame
   void Update()
   {

   }

   // 2) call function
   public void ResetPosition()
   {
      transform.position = Vector3.zero;
   }

   // 3) change position via parameters
   public void ChangePosition(Vector3 newPosition)
   {
      transform.position = newPosition;
   }

   // 4) return specified position to change to
   public Vector3 GetPosition(float x, float y, float z)
   {
      Vector3 newPos = new Vector3(x, y, z);
      return newPos;
   }
}
