using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_PositionMatters : MonoBehaviour
{
   // create an array of 5 different positions
   // use a custom method to generate a random index
   // use a custom method to set the position to that sub index
   public Vector3[] v3Positions;
   private int _maxIndex;
   private int _randomIndex;

   // Start is called before the first frame update
   private void Start()
   {
      v3Positions = new Vector3[]
      {
          Vector3.zero,
          new Vector3(1f, 1f, 0f),
          new Vector3(-2f, -2f, 0f),
          new Vector3(3f, -3f, 0f),
          new Vector3(-4f, 4f, 0f)
      };

      _maxIndex = v3Positions.Length;
   }

   // Update is called once per frame
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         _randomIndex = RandomIndex(_maxIndex);
         transform.position = GetPosition(_randomIndex);
      }
   }

   public int RandomIndex(int maxIndex)
   {
      return Random.Range(0, maxIndex);
   }

   public Vector3 GetPosition(int index)
   {
      return v3Positions[index];
   }
}
