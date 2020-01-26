using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TellMeTheNames : MonoBehaviour
{
   [SerializeField]
   private List<string> _namesList;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         foreach (var name in _namesList)
         {
            Debug.Log("Name: " + name);
         }
      }
   }
}
