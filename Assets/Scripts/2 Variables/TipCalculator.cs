using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
   // bill is $40
   [SerializeField]
   private float _bill = 40.00f;

   // tip is 20% or based on what the user wants
   [SerializeField]
   private float _tipPercentage = 20.0f;

   // calculate total amount
   [SerializeField]
   private float _total;

   // Start is called before the first frame update
   void Start()
    {
      
      // tip amount
      float _tip = _bill * (_tipPercentage / 100);
      
      // calculate total amount
      _total = _bill + _tip;

      // print message: bill = , tip = , total = 
      Debug.Log("Bill = " + _bill);
      Debug.Log("Tip  = " + _tip);
      Debug.Log("Total = " + _total);
    }

}
