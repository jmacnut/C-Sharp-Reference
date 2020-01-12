using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop_Basic : MonoBehaviour
{
   [SerializeField]
   private string myName = "Sloth";

   [SerializeField]
   private int _max = 5;

   // Start is called before the first frame update
   void Start()
   {
      // count up
      for (int i = 0; i < _max; i++)
      {
         Debug.Log("[" + i + "] " + myName);
      }
      Debug.Log("Loop 1 has finished");

      // count down
      for (int i = _max; i > 0; i--)
      {
         Debug.Log("[" + i + "] " + myName);
      }
      Debug.Log("Loop 2 has finished");

      // print even numbers
      for (int i = 0; i < _max; i++)
      {
         if (i % 2 == 0)
         {
            Debug.Log(i);
         }
      }
      Debug.Log("Loop 3 has finished");

      // print odd numbers
      for (int i = 0; i < _max; i++)
      {
         if (i % 2 == 1)
         {
            Debug.Log(i);
         }
      }
      Debug.Log("Loop 4 has finished");

      // print specific numbers
      for (int i = 0; i < _max; i++)
      {
         if (i == 42)
         {
            Debug.Log("i = " + i);
         }
      }
      Debug.Log("Loop 5 has finished");

      // break - stop counting
      for (int i = 0; i < _max; i++)
      {
         if (i == 6)
         {
            Debug.Log("Stop i = " + i);
            break;
         }
      }
      Debug.Log("Loop 6 has finished");
   }

}
