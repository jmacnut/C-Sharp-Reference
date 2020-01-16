using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Challenge:
// Create a list of names and print out each one
// When the Space key is pressed, 
//   remove a random element from the list and
//   reprint the names

public class YouHaveBeenNamed : MonoBehaviour
{
   public List<string> namesList = new List<string>();

   void Start()
   {
      namesList.Add("Name 1");
      namesList.Add("Name 2");
      namesList.Add("Name 3");
      namesList.Add("Name 4");
      namesList.Add("Name 5");

      foreach (var namex in namesList)
      {
         Debug.Log(namex);
      }

      //Debug.Log("Last Index = " + namesList.FindLastIndex());

   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {

         if (namesList.Count > 0)
         {
            var nameToRemove = namesList[Random.Range(0, namesList.Count)];

            // generate random index remove a random element
            namesList.Remove(nameToRemove);

            // reprint the list
            foreach (string namex in namesList)
            {
               Debug.Log(namex);
            }
            Debug.Log("We removed: " + nameToRemove);

         }
         else
         {
            Debug.Log("List is empty.");
         }
      }
   }
}
