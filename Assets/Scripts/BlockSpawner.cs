using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField]private Transform[] spawnPoints;
    
    [SerializeField]private GameObject blockPrefab;

    [SerializeField]private float timeToSpawn = 3f;

    //[SerializeField]private float timeToSpawn = blockPrefab;
    
    private float timeToFirstSpawn = 2f;
    
    //Start is called before the first frame update
    /*void Start()
    {
        if (Time.time>=timeToFirstSpawn)
        {
            SpawnBlocks();
            timeToFirstSpawn = Time.time + timeToSpawn;
        }
    }*/

    
    
     //Update is called once per frame
    void Update()
    {
        if (Time.time>=timeToFirstSpawn)
        {
            SpawnBlocks();
            timeToFirstSpawn = Time.time + timeToSpawn;
        }
    }
    
    void SpawnBlocks()
    {
        Random rd = new Random();
        int randomIndex = rd.Next(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
              //  Instantiate(blockPrefab ,spawnPoints[i].transform.position, Quaternion.identity);
                SimplePool.Spawn(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                //ObjectPooler.Instance.SpawnFromPool("Obstacle", transform.position, Quaternion.identity);
            }
        }
    }

//    private void OnTriggerEnter(Collider other)
//    {
//        throw new NotImplementedException();
//    }
}
