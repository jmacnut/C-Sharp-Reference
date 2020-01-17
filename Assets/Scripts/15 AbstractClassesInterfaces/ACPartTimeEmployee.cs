using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACPartTimeEmployee : ACEmployee
{
   public int hoursWorked;
   public float hourlyRate;

   public override void CalculateMonthlySalary()
   {
      throw new System.NotImplementedException();
   }
}
