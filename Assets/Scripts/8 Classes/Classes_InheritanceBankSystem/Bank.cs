using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
   // protected access - only classes that inherit (child classes) have access
   protected string branchName;
   protected string location;
   protected int cashInVault;

   protected int CheckBalance()
   {
      Debug.Log("Chceking Balance at " + branchName);
      return cashInVault;
   }

   protected void Withdrawal(int withdrawalAmt)
   {
      Debug.Log("Withdrawing Amount: ");
      cashInVault -= withdrawalAmt;
   }

   protected void Deposit(int depositAmt)
   {
      Debug.Log("Deposit Amount: ");
      cashInVault += depositAmt;
   }

}
