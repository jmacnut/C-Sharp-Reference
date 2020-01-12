using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop_Basic : MonoBehaviour
{
   // Do While loops are rarely used
   // runs at least once

   public int apples;

    // Start is called before the first frame update
    void Start()
    {
      do
      {
         // some code
         Debug.Log("Apples = " + apples);
         // index incrementer (prevents infinite loop)
         apples++;

      } while (apples < 5);   // based on index incrementer
   }

}
