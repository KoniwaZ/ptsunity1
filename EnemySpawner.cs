using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyLVL1;
    public GameObject EnemyLVL2;

    public float randomX1;
    public float randomX2;

    float nextSpawn1;
    float nextSpawn2;

    Vector2 Spawn;
    Vector2 Spawn2;

    int random;

    float time;
    private float spawnRate;
    void Start()
    {
        
    }

    void Update()
    {
        random = Random.Range(1, 100);
        Debug.Log(Time.timeSinceLevelLoad);
        time = Time.timeSinceLevelLoad;
        if(time <= 5f)
        {
            spawnRate = 1.5f;
            if (Time.time > nextSpawn1)
            {
                nextSpawn1 = Time.time + spawnRate;
                randomX1 = Random.Range(-2.5f, 2.5f);
                Spawn = new Vector2(randomX1, transform.position.y);
                Instantiate(EnemyLVL1, Spawn, Quaternion.identity);
            }
        }
        if(time > 5f)
        {
            spawnRate = 1f;
            if(random == 1)
            {
                if (Time.time > nextSpawn2)
                {
                    nextSpawn2 = Time.time + spawnRate;
                    randomX2 = Random.Range(-2.5f, 2.5f);
                    Spawn2 = new Vector2(randomX2, transform.position.y);
                    Instantiate(EnemyLVL2, Spawn2, Quaternion.identity);
                }
            }
            if (random == 99)
            {
                if (Time.time > nextSpawn1)
                {
                    nextSpawn1 = Time.time + spawnRate;
                    randomX1 = Random.Range(-2.5f, 2.5f);
                    Spawn = new Vector2(randomX1, transform.position.y);
                    Instantiate(EnemyLVL1, Spawn, Quaternion.identity);
                }
            }
        }
    }
}
