using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserPlayer : MonoBehaviour
{
    [SerializeField] float SpeedV;

    [SerializeField] LaserPlayer spawn;

    int score = 1;

    private Player player;

    void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.Translate(0, SpeedV * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            player.UpdateScore(score);
        }
    }
}
