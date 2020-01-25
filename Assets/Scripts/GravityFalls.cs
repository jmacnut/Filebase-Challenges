using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFalls : MonoBehaviour
{

   void Update()
   {
      Rigidbody rb = this.GetComponent<Rigidbody>();

      if (Input.GetKeyDown(KeyCode.Space))
      {
         GameObject.Find("Floor").GetComponent<MeshRenderer>().material.color = Color.red;
         rb.useGravity = true;
      }
   }

   private void OnTriggerEnter(Collider other)
   {
      other.GetComponent<MeshRenderer>().material.color = Color.blue;
      Destroy(this.gameObject);
   }
}
