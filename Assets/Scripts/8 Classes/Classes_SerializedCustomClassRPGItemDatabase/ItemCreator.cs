using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour
{
   public Item sword;
   public Item hammer;
   public Item bread;

   // Start is called before the first frame update
   void Start()
   {
      // 3 ways to create an object
      sword = new Item();
      sword.name = "Sword";
      sword.id = 1;
      sword.description = "This is a sword.";

      hammer = new Item("Hammer", 2, "This is a hammer.");

      bread = CreateItem("Bread", 3, "I can eat this.");
   }

   // Update is called once per frame
   void Update()
   {

   }

   private Item CreateItem(string name, int id, string description)
   {
      var item = new Item(name, id, description);

      return item;
   }
}
