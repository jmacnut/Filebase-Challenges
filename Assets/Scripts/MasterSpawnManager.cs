using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSpawnManager : MonoBehaviour
{
   [SerializeField]
   private List<GameObject> objectsToSpawn = new List<GameObject>();

   [SerializeField]
   private Transform spawnedContainer;

   [SerializeField]
   private GameObject cubePrefab;

   [SerializeField]
   private GameObject spherePrefab;

   [SerializeField]
   private GameObject capsulePrefab;

   [SerializeField]
   private GameObject cylinderPrefab;

   private int timeToLive = 2;

   private void Start()
   {
      objectsToSpawn.Add(cubePrefab);
      objectsToSpawn.Add(spherePrefab);
      objectsToSpawn.Add(capsulePrefab);
      objectsToSpawn.Add(cylinderPrefab);

      StartCoroutine(SpawnTimerRoutine());
   }

   private void Update()
   {

   }

   IEnumerator SpawnTimerRoutine()
   {
      while (true)
      {
         StartCoroutine(ObjectSpawnerRoutine());
         yield return new WaitForSeconds(timeToLive);
      }
   }

   IEnumerator ObjectSpawnerRoutine()
   {
      List<GameObject> spawnedObjects = new List<GameObject>();


      foreach (var obj in objectsToSpawn)
      {
         int index = Random.Range(0, 3);

         float xpos = Random.Range(-6f, 6f);
         float ypos = Random.Range(-3f, 3f);
         float zpos = Random.Range(-3f, 3f);

         Vector3 newPos = new Vector3(xpos, ypos, zpos);

         spawnedObjects.Add(Instantiate(objectsToSpawn[index], newPos, Quaternion.identity, spawnedContainer));

      }

      yield return new WaitForSeconds(timeToLive);

      // collect SpawnedItem and destroy them
      foreach (var obj in spawnedObjects)
      {
         Destroy(obj);
      }

   }

}