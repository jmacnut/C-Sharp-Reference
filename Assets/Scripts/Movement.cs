using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Debug.Log("Space Key Pressed");
      }

      if (Input.GetKey(KeyCode.H))
      {
         Debug.Log("H Key Held");
      }

      if (Input.GetKeyUp(KeyCode.R))
      {
         Debug.Log("A Key Released");
      }
   }
}
