using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SwitchWeaponSelect : MonoBehaviour
{
   // weapon IDs:
   // ID 1 = Gun
   // ID 2 = Knife
   // ID 3 = Sword

   [SerializeField]
   private int weaponId;

   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
      switch (weaponId)
      {
         case 1:
            Debug.Log("Gun");
            break;
         case 2:
            Debug.Log("Knife");
            break;
         case 3:
            Debug.Log("Sword");
            break;
         default:
            Debug.Log("Invalid WeaponId: " + weaponId);
            break;
      }
   }
}
