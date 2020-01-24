using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGL : MonoBehaviour
{
   [SerializeField]
   private int _age;

   [SerializeField]
   private string _gender;

   [SerializeField]
   private string _location;

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Debug.Log(_age + " " + _gender + " " + _location);
      }
   }
}
