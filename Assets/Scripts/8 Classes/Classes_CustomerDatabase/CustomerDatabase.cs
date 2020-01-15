using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
   //public Customer[] customers;

   public Customer jonathan;
   public Customer janet;
   public Customer jessica;
   public Customer eric;

   // Start is called before the first frame update
   private void Start()
   {
      //customers = new Customer[5];
      //customers[0] = CreateCustomer("FirstName1", "LastName1", 27, "F", "Unity Developer");
      //customers[1] = CreateCustomer("FirstName2", "LastName2", 33, "M", "Game Design Artist");
      //customers[2] = CreateCustomer("FirstName3", "LastName3", 41, "F", "Technical Artist");
      //customers[3] = CreateCustomer("FirstName4", "LastName4", 55, "F", "Digital Artist");

      jonathan = new Customer("Jonathan", "Weinberger", 26, "M", "Software Engineer");
      janet = new Customer("Janet", "Bliss", 55, "F", "Instructor");
      jessica = new Customer("Jessica", "Lang", 33, "F", "Scientist");
   }

   // Update is called once per frame
   private void Update()
   {

   }

   public Customer CreateCustomer(string firstName, string lastName, int age, string gender, string occupation)
   {
      return new Customer(firstName, lastName, age, gender, occupation);
   }
}
