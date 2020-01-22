using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    void Start()
    {
      UIManager.Instance.UpdateScore(33);
      GameManager.Instance.DisplayName();
      SpawnManager.Instance.StartSpawning();
    }
}
