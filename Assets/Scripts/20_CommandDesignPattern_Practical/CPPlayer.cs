using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manages Input

public class CPPlayer : MonoBehaviour
{
   CPICommand moveUp, moveDown, moveLeft, moveRight;

   [SerializeField]
   private float _speed = 2.0f;


   void Start()
   {

   }

   void Update()
   {
      // up key
      if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
      {
         // move up command
         moveUp = new MoveUpCommand(this.transform, _speed);
         moveUp.Execute();
         CPCommandManager.Instance.AddCommand(moveUp);
      }
      else if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
      {
         // move down command
         moveDown = new MoveDownCommand(this.transform, _speed);
         moveDown.Execute();
         CPCommandManager.Instance.AddCommand(moveDown);
      }
      else if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
      {
         // move left command
         moveLeft = new MoveLeftCommand(this.transform, _speed);
         moveLeft.Execute();
         CPCommandManager.Instance.AddCommand(moveLeft);
      }
      else if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
      {
         // move right command
         moveRight = new MoveRightCommand(this.transform, _speed);
         moveRight.Execute();
         CPCommandManager.Instance.AddCommand(moveRight);
      }
   }
}
