using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerPlayer : MonoBehaviour
{

    void Start()
    {
      UIManager.Instance.UpdateScore(50);
    }

}
