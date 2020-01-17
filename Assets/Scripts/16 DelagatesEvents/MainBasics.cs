using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Delegates - variables that hold methods
// Note: return type and parameter(s) type and qty must match in method signature 
// in order to assign a method to a delegate

public class MainBasics : MonoBehaviour
{
   // declare delegate with signature for a method
   public delegate void ChangeColor(Color newColor);

   public ChangeColor onColorChange;  // cannot be assigned to call void Task()


   // can only be called on methods where signature accessor and paramerter(s) match
   public delegate void OnComplete();

   public OnComplete onComplete;      // can be assigned to call void Task()


   // usage of delegate
   private void Start()
   {
      onColorChange = UpdateColor;  // works because void and parameters same
      onColorChange(Color.green);   // calls ChangeColor()
                                    //onColorChange = Task;       // does not work because parameters don't match

      onComplete = Task;           // works because void and parameters same
      // multi cast delegates
      onComplete += Task1;         // register          
      onComplete += Task2;
      onComplete += Task3;

      onComplete -= Task;          // deregister


      // best practice: check for null values before invoking delegate
      if (onComplete != null)
      {
         onComplete();             // calls delegate for Taskx method
      }

   }

   // signature void _____ (Color _____)   - 1 parameter
   public void UpdateColor(Color newColor)
   {
      Debug.Log("Changing color to " + newColor.ToString());
   }

   // signature void _____ ()   - no parameter
   public void Task()
   {
      Debug.Log("Task Finished!");

   }

   public void Task1()
   {
      Debug.Log("Task 1 Finished!");

   }

   public void Task2()
   {
      Debug.Log("Task 2 Finished!");

   }

   public void Task3()
   {
      Debug.Log("Task 3 Finished!");

   }

}
