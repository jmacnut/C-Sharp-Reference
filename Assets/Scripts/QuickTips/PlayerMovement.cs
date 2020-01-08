using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Vector3 startPosition = new Vector3(6f, 0f, 0f);

   [SerializeField]
   private float _speed;
   private float _horizontalPosition;
   private float _verticalPosition;

    // Start is called before the first frame update
    void Start()
    {
      // resets player position
      transform.position = startPosition;
      _speed = 3.0f;
   }

    // Update is called once per frame
    void Update()
    {
      // player position can come from a and d keys or <- and -> keys
      // see key assignments in Unity IDE:
      // Edit-Project Settings-Input Manager-Axes-Horizontal and Vertical
      _horizontalPosition = Input.GetAxis("Horizontal");
      _verticalPosition = Input.GetAxis("Vertical");
      Vector3 currentPosition = new Vector3(_horizontalPosition, _verticalPosition, 0);

      // move player
      transform.Translate(currentPosition * _speed * Time.deltaTime);

    }
}
