using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPlayer : MonoBehaviour
{
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         //UtilityColorHelper.ChangeColor(this.gameObject, Color.red);
         UtilityColorHelper.ChangeColor(this.gameObject, Color.red, true);
      }
   }
}
