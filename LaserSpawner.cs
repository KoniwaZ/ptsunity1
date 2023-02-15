using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public GameObject LaserPlayer;

    public GameObject Player;

    public float loctX;
    public float loctY;

    float nextSpawn;

    Vector2 Spawn;

    [SerializeField] float spawnRate;
    void Start()
    {

    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            loctX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
            loctY = GameObject.FindGameObjectWithTag("Player").transform.position.y;
            Spawn = new Vector2(loctX, loctY);
            Instantiate(LaserPlayer, Spawn, Quaternion.identity);
        }
    }
}
