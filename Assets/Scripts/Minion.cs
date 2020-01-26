using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour 
{
   public float _speed = 0.1f;
   float xpos;
   float ypos;
   float zpos;

   void Start () {
      xpos = transform.position.x;
      ypos = transform.position.y;
      zpos = transform.position.z;
   }
	
	void Update () {

      Vector3 currPos = new Vector3(xpos++, -2.384f, 0);
      transform.position = currPos;

      if (xpos >= 6.63)
      {
         Destroy(this.gameObject);
      }
   }
}
