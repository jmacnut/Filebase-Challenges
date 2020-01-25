using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere02Controller : MonoBehaviour
{
   public GameObject sphere03;

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.name == "Floor")
      {
         Debug.Log("Sphere 02 hit the Floor!");
         transform.GetComponent<MeshRenderer>().material.color = Color.red;
         sphere03.GetComponent<Rigidbody>().useGravity = true;
      }
   }
}
