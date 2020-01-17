using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ACEmployee : MonoBehaviour
{
   public static string companyName = "GameDevHQ";
   public string employeeName;

   public abstract void CalculateMonthlySalary();
}


