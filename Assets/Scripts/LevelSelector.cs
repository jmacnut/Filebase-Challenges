using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelSelector : MonoBehaviour
{
   // both accessors must be the same level

   //private enum Level : short { Easy = 1, Medium = 2, Hard = 3 };
   private enum Level : short { Easy, Medium, Hard };

   [SerializeField]
   private Level _level;

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Debug.Log("You selected " + _level);
      }
   }
}
