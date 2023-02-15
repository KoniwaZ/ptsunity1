using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] float SpeedV;

    [SerializeField] BackgroundSpawner spawn;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(0, -SpeedV * Time.deltaTime, 0);
    }
}
