using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_IfThenElseLogic : MonoBehaviour
{
   //// level of difficulty:
   //[SerializeField]
   //private int _points;
   //private bool _messageSent = false;

   //// Start is called before the first frame update
   //void Start()
   //{

   //}

   //// Update is called once per frame
   //void Update()
   //{
   //   if (Input.GetKeyDown(KeyCode.Space))
   //   {
   //      _points += 10;
   //   }

   //   // compound conditions
   //   if ((_points >= 50) && (_messageSent == false))
   //   {
   //      Debug.Log("You Rock!!");
   //      _messageSent = true;
   //   }
   //}

   // speed control:
   [SerializeField]
   private int _speed;

   private void Start()
   {

   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.S))
      {
         // speed up
         _speed += 5;
      }

      if (Input.GetKeyDown(KeyCode.A))
      {
         // slow down
         _speed -= 5;
      }
      
      
      if (_speed > 20)
      {
         Debug.Log("Slow down!");
      }

      else if (_speed == 0)
      {
         Debug.Log("Speed up!");
      }
      else
      {
         Debug.Log("Speed is Good!");
      }

      if (_speed < 0)
      {
         _speed = 0;
      }
   }
}
