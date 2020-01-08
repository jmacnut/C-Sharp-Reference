using System.Collections;
using System.Collections.Generic;
using UnityEngine;   // enables use of MonoBehaviour and Unity API in this C# script

public class PlayerVariables : MonoBehaviour   // access to Unity API
{
   /// <summary>
   /// Variables:
   ///   reference: public (accessible in IDE and other objects) or 
   ///              private (accessible only to this script)
   ///   data type: strings, bools, float/double, int/long, char, object, decimal, byte, DateTime
   ///   name: 
   ///   optional: value
   /// </summary>

   // accessible to IDE, which overrides this script
   public string myName = "jmacnut";
   public int myAge = 26;
   public string myLocation = "Honolulu";

   public float mySpeed = 10.2f;   // must include the "f" for float values
   public int myHealth= 100;
   public int myScore = 120;
   public int myAmmoCount = 66;
   public bool hasAllKeys = false;

   // drag objects or prefabs into Editor fields
   public GameObject player;
   public Animator anim;
   public Transform myTransform;


   // Start is called before the first frame update
   void Start()
   {
      // overrides initialized values
      myName = "New Name";
      myAge = 33;
      myLocation = "Sydney";

      Debug.Log("Name: " + myName);
      Debug.Log("Age: " + myAge); 
      Debug.Log("Location: " + myLocation);

      Debug.Log("Speed: " + mySpeed);
      Debug.Log("Health: " + myHealth);
      Debug.Log("Score: " + myScore);
      Debug.Log("Ammo Count: " + myAmmoCount);
      Debug.Log("Has All Keys: " + hasAllKeys);

      Debug.Log("myTransform.position.x: " + myTransform.position.x);
      Debug.Log("myTransform.position.y: " + myTransform.position.y);
      Debug.Log("myTransform.position.z: " + myTransform.position.z);
   }

}
