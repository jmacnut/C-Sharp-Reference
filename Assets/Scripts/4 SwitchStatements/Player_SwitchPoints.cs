﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SwitchPoints : MonoBehaviour
{
   [SerializeField]
   private int _points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Q))
      {
         _points = 50;
      }
      else if (Input.GetKeyDown(KeyCode.W))
      {
         _points = 100;
      }
      else if (Input.GetKeyDown(KeyCode.E))
      {
         _points = 0;
      }

      switch (_points)
      {
         case 50:
            Debug.Log("Points = 50!");
            break;
         case 100:
            Debug.Log("Points = 100!!");
            break;
         default:
            Debug.Log("You need 50 or 100 points.");
            break;
      }
   }
}
