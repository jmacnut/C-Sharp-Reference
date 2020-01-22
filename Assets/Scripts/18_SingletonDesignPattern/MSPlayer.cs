using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSPlayer : MonoSingleton<MSPlayer>
{
   public string name;

   public override void Init()
   { 
      base.Init();

      Debug.Log("Player Initialized!");

      LevelManager.Instance.LoadLevel(1);

   }
}
