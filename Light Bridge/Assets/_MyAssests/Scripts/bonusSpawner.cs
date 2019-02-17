using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonusSpawner : MonoBehaviour
{

    public GameObject[] bonus;
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
        //if random number is greater than 700 make a bonus pickup
        if (rand > 700)
        {
            Instantiate(bonus[Random.Range(0, bonus.GetLength(0))], transform.position, Quaternion.identity);
        }
        //invoke spawn at random time interval between min and max
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
