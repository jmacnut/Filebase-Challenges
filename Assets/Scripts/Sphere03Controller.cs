using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere03Controller : MonoBehaviour
{
   public GameObject sphere01;
   public GameObject sphere02;

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.name == "Floor")
      {
         Debug.Log("Sphere 03 hit the Floor!");
         transform.GetComponent<MeshRenderer>().material.color = Color.green;
         sphere01.GetComponent<MeshRenderer>().material.color = Color.green;
         sphere02.GetComponent<MeshRenderer>().material.color = Color.green;
      }
   }
}
