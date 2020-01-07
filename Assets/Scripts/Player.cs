using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // Reset Player Position
   public Vector3 resetPosition;


   // Player Movement
   [SerializeField]
   private float _speed;

   [SerializeField]
   private float _horizontalMovement;

   [SerializeField]
   private float _verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
      // Reset Player Position
      //transform.position = new Vector3(0, 0, 0);
      transform.position = resetPosition;

      // Player Movement
      _speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
      // Player Movement
      _horizontalMovement = Input.GetAxis("Horizontal");
      _verticalMovement = Input.GetAxis("Vertical");
      Vector3 movement = new Vector3(_horizontalMovement, _verticalMovement, 0);

      // Player Movement
      transform.Translate(movement * _speed * Time.deltaTime);

    }
}
