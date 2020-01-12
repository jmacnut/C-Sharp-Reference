using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays_RandomChoose : MonoBehaviour
{
   public string[] names;
   public int[] ages;
   public string[] cars;
   public int randomIndex;

   // Start is called before the first frame update
   void Start()
    {
      names = new string[5] { "Leia", "Rey", "BB8", "R2D2", "DO" };
      ages = new int[5] { 52, 23, 6, 15, 2 };
      cars = new string[5] { "Prius", "Tacoma", "Cooper", "Beatle", "Smart" };
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         randomIndex = Random.Range(0, names.Length);
         Debug.Log("Random Index = " + randomIndex);
         Debug.Log("Name: " + names[randomIndex] + " Age: " + ages[randomIndex] + " Car: " + cars[randomIndex]);
      }
   }
}
