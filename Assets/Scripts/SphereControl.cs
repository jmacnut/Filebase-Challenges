using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{

   public GameObject sphere01;
   public GameObject sphere02;
   public GameObject sphere03;
   public GameObject floor;

   void Start()
   {

   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         if (sphere01)
         {
            sphere01.GetComponent<Rigidbody>().useGravity = true;
         }
      }
   }

}
