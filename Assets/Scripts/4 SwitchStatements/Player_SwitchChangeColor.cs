using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SwitchChangeColor : MonoBehaviour
{
   [SerializeField]
   private GameObject _colorCube;

   [SerializeField]
   private int _colorCode;

    // Start is called before the first frame update
    void Start()
    {
      _colorCode = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Alpha0))
      {
         _colorCode = 0;
      }

      if (Input.GetKeyDown(KeyCode.Alpha1))
      {
         _colorCode = 1;
      }

      if (Input.GetKeyDown(KeyCode.Alpha2))
      {
         _colorCode = 2;
      }

      if (Input.GetKeyDown(KeyCode.Alpha3))
      {
         _colorCode = 3;
      }

      if (Input.GetKeyDown(KeyCode.Alpha4))
      {
         _colorCode = 4;
      }


      switch (_colorCode)
      {
         case 1:
            // chance color to blue
            Debug.Log("Color: Blue");
            _colorCube.GetComponent<Renderer>().material.color = Color.blue;
            break;
         case 2:
            // change color to red
            Debug.Log("Color: Red");
            _colorCube.GetComponent<Renderer>().material.color = Color.red;
            break;
         case 3:
            // change color to green
            Debug.Log("Color: Green");
            _colorCube.GetComponent<Renderer>().material.color = Color.green;
            break;
         case 4:
            // change color to black
            Debug.Log("Color: Black");
            _colorCube.GetComponent<Renderer>().material.color = Color.black;
            break;
         default:
            // invalid color code
            Debug.Log("Invalid Color Code: " + _colorCode);
            _colorCube.GetComponent<Renderer>().material.color = Color.white;
            break;
      }
   }
}
