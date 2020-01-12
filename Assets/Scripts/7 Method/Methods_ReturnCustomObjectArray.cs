using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods_ReturnCustomObjectArray : MonoBehaviour
{
   public GameObject[] players;

   // Start is called before the first frame update
   void Start()
   {
      players = GetAllPlayers();
   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         foreach (var player in players)
         {
            player.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
         }
      }
   }

   GameObject[] GetAllPlayers()
   {
      return GameObject.FindGameObjectsWithTag("ColoredPlayer");

      //GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

      //foreach (var p in allPlayers)
      //{
      //   p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
      //}
      //return allPlayers;
   }
}
