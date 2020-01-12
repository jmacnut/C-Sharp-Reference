using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop_Coroutine : MonoBehaviour
{
   // While Loop with infinite loop coroutine to create delay

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(DelayRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayRoutine()
   {
      yield return new WaitForSeconds(1.0f);
      Debug.Log("Spawning Enemy Every Second");
   }
}
