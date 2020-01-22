using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIPlayer : MonoBehaviour
{
    void Start()
    {
      SpawnManager.Instance.StartSpawning();
    }
    
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         UIManager_LI.Instance.UpdateScore(33);
      }
   }
}
