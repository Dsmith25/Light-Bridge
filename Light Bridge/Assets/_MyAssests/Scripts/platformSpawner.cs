using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{

    public GameObject[] platforms;
    public float spawnMin;
    public float spawnMax;

    void Start()
    {
        Spawn();
    }

    // spawns bombs at a random range at random intervals
    void Spawn()
    {
        float rand = Random.Range(0, 1000);
        //if random number is greater than 700 make a platform
        if (rand > 700)
        {
            Instantiate(platforms[Random.Range(0, platforms.GetLength(0))], transform.position, Quaternion.identity);
        }
        //invoke spawn at random time interval between min and max
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}

