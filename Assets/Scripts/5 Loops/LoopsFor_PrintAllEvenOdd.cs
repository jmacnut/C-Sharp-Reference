using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsFor_PrintAllEvenOdd : MonoBehaviour
{
   public int counter;
   public int max = 30;

   // Start is called before the first frame update
   void Start()
   {
      for (counter = 0; counter <= max; counter++)
      {
         if (counter < 10)
         {
            Debug.Log("counter[0-9] ALL: " + counter);
         }
         else if (counter <= 20 && counter % 2 == 0)
         {
            Debug.Log("counter[10-19] EVEN: " + counter);
         }
         else if (counter > 20 && counter % 2 == 1)
         {
            Debug.Log("counter[20-30] ODD: " + counter);
         }
      }
   }

}
