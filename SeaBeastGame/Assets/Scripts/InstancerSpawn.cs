using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


public class InstancerSpawn : MonoBehaviour
{

    public GameObject[] prefabbedData;

   
    public Vector3DataList spawnPos;
    public Vector3DataList spawnPosEnemy;

    

    
    public void Awake()
    {
        Spawnrandom();
        //bb.BrickRestart();

    }
    
    // public void SpawnAll()
    // {
    //     foreach  (Vector3 position in spawnPos.vector3List)
    //     {
    //         int obstacal = Random.Range(0, prefabbedData.Length);
    //         Instantiate(prefabbedData[obstacal], position, Quaternion.identity);
    //     }
    // }

     public void Spawnrandom()
     {
         int obstacal = Random.Range(0, prefabbedData.Length);
         int position = Random.Range(0, spawnPos.vector3List.Count -1);
         //Vector3 spawnPos = new Vector3(99, 99, 99);
         Instantiate(prefabbedData[obstacal], spawnPos.vector3List[position], Quaternion.identity);
         Instantiate(prefabbedData[obstacal], spawnPosEnemy.vector3List[position], Quaternion.identity);

         //spawnPos, quaternion.identity
         
     }
    


    // public void StartSpawning()
    // {
    //     InvokeRepeating("Spawnrandom");
    // }
    // private IEnumerator StartSpawning()
    // {
    //     
    //     yield return prefabbedData;
    // }
   
}
