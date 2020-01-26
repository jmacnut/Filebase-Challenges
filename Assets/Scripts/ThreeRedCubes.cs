using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeRedCubes : MonoBehaviour
{
   public GameObject[] cubes;

   void Start()
   {
      cubes = GameObject.FindGameObjectsWithTag("Cube");
   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         foreach (var cube in cubes)
         {
            cube.GetComponent<MeshRenderer>().material.color = Color.red;
         }
      }
   }
}
