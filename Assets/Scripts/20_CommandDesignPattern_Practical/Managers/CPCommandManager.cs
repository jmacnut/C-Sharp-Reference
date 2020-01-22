using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CPCommandManager : MonoBehaviour
{
   private static CPCommandManager _instance;
   public static CPCommandManager Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.LogError("The CPCommandManager is NULL.");
         }
         return _instance;
      }
   }

   private List<CPICommand> _commandBuffer = new List<CPICommand>();

   private void Awake()
   {
      _instance = this;  
   }

   public void AddCommand(CPICommand command)
   {
      _commandBuffer.Add(command);
   }

   public void Rewind()
   {
      StartCoroutine(RewindRoutine());
   }

   IEnumerator RewindRoutine()
   {
      Debug.Log("Rewinding...");

      foreach (var command in Enumerable.Reverse(_commandBuffer))
      {
         command.Undo();
         yield return new WaitForEndOfFrame();
      }

      Debug.Log("Finished Rewinding...");
   }

   public void Playback()
   {
      StartCoroutine(PlaybackRoutine());
   }

   IEnumerator PlaybackRoutine()
   {
      Debug.Log("Playing...");

      foreach (var command in _commandBuffer)
      {
         command.Execute();
         yield return new WaitForEndOfFrame();
      }

      Debug.Log("Finished Playing...");
   }
}
