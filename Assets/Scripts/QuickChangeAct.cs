using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickChangeAct : MonoBehaviour
{
   [SerializeField]
   private float _speed = 5;

   private void Update()
   {
      if (Input.GetKey(KeyCode.RightArrow))
      {
         transform.Translate(Vector3.right * _speed * Time.deltaTime);
      }
      else if (Input.GetKey(KeyCode.LeftArrow))
      {
         transform.Translate(Vector3.left * _speed * Time.deltaTime);
      }
   }

   private void OnTriggerExit(Collider other)
   {
      this.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
   }
}
