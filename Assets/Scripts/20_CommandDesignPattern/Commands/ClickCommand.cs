using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
   private GameObject _cube;
   private Color _color;
   private Color _previousColor;

   // constructor
   public ClickCommand(GameObject cube, Color color)
   {
      this._cube = cube;
      this._color = color;
   }

   public void Execute()
   {
      _previousColor = _cube.GetComponent<MeshRenderer>().material.color;

      // change the color of the cube to a random color
      // assign a random color
      _cube.GetComponent<MeshRenderer>().material.color = _color;
         //new Color(Random.value, Random.value, Random.value);
   }

   public void Undo()
   {
      _cube.GetComponent<MeshRenderer>().material.color = _previousColor;
   }
}
