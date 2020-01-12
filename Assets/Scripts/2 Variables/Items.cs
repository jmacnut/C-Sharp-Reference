using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
   // every item has a name
   [SerializeField]
   private string _itemName = "CHALLENGE";

   // every item has a description
   [SerializeField]
   private string _itemDescription = "This is a challenge icon.";

   // every item has an image icon (sprite)
   [SerializeField]
   private Sprite _itemIcon;

   // every item has an attack strength
   [SerializeField]
   private float _attackStrength = 50.0f;

   // Start is called before the first frame update
   void Start()
   {
      Debug.Log("Name: " + _itemName);
      Debug.Log("Description: " + _itemDescription);
      Debug.Log("Attack Strength" + _attackStrength);
   }

}
