using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsWhile_MaxSpeed : MonoBehaviour
{
   [SerializeField]
   private int _maxSpeed;

   [SerializeField]
   private int _speed;

   // Start is called before the first frame update
   void Start()
   {
      _maxSpeed = Random.Range(60, 120);

      StartCoroutine(IncrementSpeed());
   }

   // Update is called once per frame
   void Update()
   {
   }

   IEnumerator IncrementSpeed()
   {
      while (true)
      {
         yield return new WaitForSeconds(0.5f);
         _speed += 5;

         if (_speed > _maxSpeed)
         {
            Debug.Log("Max Speed Achieved");
            break;
         }
      }
   }
}
