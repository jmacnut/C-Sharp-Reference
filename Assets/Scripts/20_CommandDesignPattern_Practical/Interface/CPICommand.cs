using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CPICommand
{
   void Execute();

   void Undo();
}
