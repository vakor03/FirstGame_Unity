using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;

    public float timeBetweenSpawns;
    private float nextSpawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }
}
