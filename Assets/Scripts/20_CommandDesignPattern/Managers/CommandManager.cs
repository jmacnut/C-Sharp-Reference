using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
   private static CommandManager _instance;
   public static CommandManager Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.LogError("The Command Manager is NULL.");
         }
         return _instance;
      }
   }

   private List<ICommand> _commandBuffer = new List<ICommand>();

   private void Awake()
   {
      _instance = this;
   }

   // Challenge:

   // create a method to "add" commands to the command buffer
   public void AddToCommandBuffer(ICommand command)
   {
      _commandBuffer.Add(command);
   }

   // create a play routine triggered by a play method that's going to playback all the commands with 1 sec delay
   public void PlaybackCommand()
   {
      StartCoroutine(PlaybackRoutine());
   }

   IEnumerator PlaybackRoutine()
   {
      Debug.Log("Playing...");

      foreach (var command in _commandBuffer)
      {
         command.Execute();
         yield return new WaitForSeconds(1f);
      }

      Debug.Log("Finished Playback...");
   }

   // Rewind routine triggered by a rewind method that's going to play in reverse with a 1 sec delay
   public void RewindCommand()
   {
      StartCoroutine(RewindRoutine());
   }

   IEnumerator RewindRoutine()
   {
      Debug.Log("Rewind...");
      
      foreach (var command in Enumerable.Reverse(_commandBuffer))
      {
         command.Undo();
         yield return new WaitForSeconds(1.0f);
      }
      
      Debug.Log("Finished Rewind...");
   }

   // Done - Finished with changing colors. Turn all the cubes white
   public void DoneCommand()
   {
      var cubes = GameObject.FindGameObjectsWithTag("Cube");
      foreach (var cube in cubes)
      {
         cube.GetComponent<MeshRenderer>().material.color = Color.white;
      }
   }

   // Reset - clear the command buffer
   public void ResetCommand()
   {
      _commandBuffer.Clear();
   }
}
