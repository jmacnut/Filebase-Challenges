﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPainting : MonoBehaviour
{
   [SerializeField]
   private float _speed = 5.0f;

   [SerializeField]
   private GameObject dropletPrefab;

   private float timer = 2f;


   void Start()
   {

   }

   void Update()
   {
      timer -= Time.deltaTime;

      if (Input.GetKey(KeyCode.W))
      {
         transform.Translate(Vector3.forward * _speed * Time.deltaTime);
         if (timer <= 0)
         {
            Instantiate(dropletPrefab, this.transform);
            timer = 2f;
         }
      }
      else if (Input.GetKey(KeyCode.S))
      {
         transform.Translate(Vector3.back * _speed * Time.deltaTime);
         if (timer <= 0)
         {
            Instantiate(dropletPrefab, this.transform);
            timer = 2f;
         }
      }
      else if (Input.GetKey(KeyCode.A))
      {
         transform.Translate(Vector3.left * _speed * Time.deltaTime);
         if (timer <= 0)
         {
            Instantiate(dropletPrefab, this.transform);
            timer = 2f;
         }
      }
      else if (Input.GetKey(KeyCode.D))
      {
         transform.Translate(Vector3.right * _speed * Time.deltaTime);
         if (timer <= 0)
         {
            Instantiate(dropletPrefab, this.transform);
            timer = 2f;
         } 
      }



   }

}
