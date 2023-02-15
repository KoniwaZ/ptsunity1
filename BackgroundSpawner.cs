using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public GameObject Background1;
    public GameObject Background2;

    public float randomX;
    float nextSpawn;
    Vector2 Spawn;

    public int spawnRate;

    private int ranB;
    void Start()
    {

    }

    void Update()
    {
        ranB = Random.Range(1, 2);

        if(ranB == 1)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randomX = Random.Range(-2.5f, 2.5f);
                Spawn = new Vector2(randomX, transform.position.y);
                Instantiate(Background1, Spawn, Quaternion.identity);
            }
        }
        if (ranB == 2)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randomX = Random.Range(-2.5f, 2.5f);
                Spawn = new Vector2(randomX, transform.position.y);
                Instantiate(Background2, Spawn, Quaternion.identity);
            }
        }
    }
}
