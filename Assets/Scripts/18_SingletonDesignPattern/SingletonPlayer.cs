using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPlayer : MonoBehaviour
{
   void Start()
   {
      // accessing the singelton
      GameManager.Instance.DisplayName();
   }

}
