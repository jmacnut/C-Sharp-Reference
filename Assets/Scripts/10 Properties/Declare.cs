using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Declare Properties

public class Declare : MonoBehaviour
{
   // declare auto-property
   //public float Speed { get; private set; }
   // or
   //public float Speed { get; }

   // declare property Speed (read only)
   private float _speed;
   public float Speed
   {
      get
      {
         Debug.Log("Speed value was returned.");
         return _speed;
      }

      private set
      {
         _speed = value;
         Debug.Log("Speed value was set.");
      }
   }


   // auto-property Name (public)
   public string Name { get; set; }

   // or
   //private string _name;
   //public string Name
   //{
   //   get
   //   {
   //      return _name;
   //   }

   //   set
   //   {
   //      _name = value;
   //   }

   //}

   void Start()
   {
      // test private setter (only works in this class)
      //_speed = 55f;
      Speed = 55f;
      // test getter
      Debug.Log("Speed = " + Speed);

      // test setter
      Name = "First Last";
      // test getter
      Debug.Log("Name is " + Name);
   }


   void Update()
   {

   }
}

// test private set
public class TestDeclareProperties
{
   Declare gm = new Declare();

   public TestDeclareProperties()
   {
      // cannot set, since it is private
      //gm.Speed = 66f;

      // can get public
      Debug.Log("Speed = " + gm.Speed);


      // can get and set name
      gm.Name = "Somebody";
      Debug.Log("Name is " + gm.name);

   }
}