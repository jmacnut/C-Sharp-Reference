using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_PassObjectWithColor : MonoBehaviour
{
   public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
      if (playerObject == null)
      {
         Debug.LogError("playerObject is NULL");
      }
      else
      {
         Debug.Log("playerObject exists");
      }
   }

   // Update is called once per frame
   void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         ChangeObjectColor(playerObject, Color.magenta);
      }
   }

   void ChangeObjectColor(GameObject gameObj, Color objColor)
   {
      gameObj.GetComponent<MeshRenderer>().material.color = objColor;
   }
}
