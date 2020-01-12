using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays_Syntax : MonoBehaviour
{
   // 3 Ways to Declare and Array

   // 1: declare the size via the Inspector
   public string[] names;

   // 2: declare size in initialization
   public string[] items = new string[5];

   // 3: declare vaues in code
   public int[] ages = new int[] { 5, 3, 2, 55, 66 };

   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {

   }
}
