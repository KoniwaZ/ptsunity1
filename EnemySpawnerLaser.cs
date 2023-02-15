using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerLaser : MonoBehaviour
{
    public GameObject LaserEnemy;

    public GameObject Enemy;

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
            loctX = this.gameObject.transform.position.x;
            loctY = this.gameObject.transform.position.y;
            Spawn = new Vector2(loctX, loctY);
            Instantiate(LaserEnemy, Spawn, Quaternion.identity);
        }
    }
}
