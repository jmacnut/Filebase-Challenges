using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawnManager : MonoBehaviour
{
   public GameObject minionPrefab;
   public Transform minionTransform;

    void Start()
    {
        
    }
    
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Instantiate(minionPrefab, minionTransform);
      }
   }
}
