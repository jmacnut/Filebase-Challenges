using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere01Controller : MonoBehaviour
{
   public GameObject sphere02;

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.name == "Floor")
      {
         Debug.Log("Sphere 01 hit the Floor!");
         transform.GetComponent<MeshRenderer>().material.color = Color.red;
         sphere02.GetComponent<Rigidbody>().useGravity = true;
      }
   }
}
