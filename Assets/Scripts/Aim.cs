using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
   [SerializeField]
   private Transform _sphere;   // target sphere



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Vector3 direction = destination pos - source pos
      Vector3 directionToFace = _sphere.position - transform.position;
      Debug.DrawRay(transform.position, directionToFace, Color.green);  // see the direction calculation

      // access our current rotation =>  Quaternion Look Rotation
      Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
      transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 1);
    }
}
