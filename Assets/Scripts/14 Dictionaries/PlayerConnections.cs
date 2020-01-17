using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectedPlayer
{
   public string name;
   public int id;

   public ConnectedPlayer(int id)
   {
      this.id = id;
   }
}

public class PlayerConnections : MonoBehaviour
{
   public Dictionary<int, ConnectedPlayer> cpDictionary = new Dictionary<int, ConnectedPlayer>();
   ConnectedPlayer cp1;
   ConnectedPlayer cp2;
   ConnectedPlayer cp3;

   private void Start()
   {
      cp1 = new ConnectedPlayer(1);
      cp1.name = "Jamaica";
      cp2 = new ConnectedPlayer(200);
      cp2.name = "Kylo";
      cp3 = new ConnectedPlayer(9);
      cp3.name = "Yin";

      cpDictionary.Add(cp1.id, cp1);
      cpDictionary.Add(cp2.id, cp2);
      cpDictionary.Add(cp3.id, cp3);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         // direct access
         //var cplayer = cpDictionary[200];
         //var cplayer = cpDictionary[cp2.id];
         //Debug.Log("Player [200] Name: " + cplayer.name);

         foreach (KeyValuePair<int, ConnectedPlayer> item in cpDictionary)
         {
            Debug.Log("Key: " + item.Key + " ID: " + item.Value.id + " Name: " + item.Value.name);
         }
      }
   }

}