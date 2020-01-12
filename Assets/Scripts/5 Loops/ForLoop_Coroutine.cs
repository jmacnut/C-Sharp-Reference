using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop_Coroutine : MonoBehaviour
{
   // use of a coroutine to watch/delay increment number of apples
   public int apples;
   public int max = 100;

    // Start is called before the first frame update
    void Start()
    {
      // watch Apples field in IDE (under Camera)
      StartCoroutine(AddApplesRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

   IEnumerator AddApplesRoutine()
   {
      for (int i = 0; i < max; i++)
      {
         apples++;
         yield return new WaitForSeconds(0.5f);
      }
   }
}
