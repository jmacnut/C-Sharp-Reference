using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_ReturnDataTypes : MonoBehaviour
{
   public int total1;
   public int total2;

   // Start is called before the first frame update
   void Start()
   {
      total1 = Sum(5, 2);
      total2 = Sum(10, 2);
   }

   // Update is called once per frame
   void Update()
   {

   }

   private int Sum(int a, int b)
   {
      return a + b;
   }
}
