using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_Parameters : MonoBehaviour
{
   public int health = 50;

   public void Damage(int damageAmount)
   {
      health -= damageAmount;

      if (health < 1)
      {
         health = 0;
         Destroy(this.gameObject);
      }
   }

   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Damage(5);
      }

   }

}
