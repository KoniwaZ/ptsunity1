using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserEnemy1 : MonoBehaviour
{
    [SerializeField] float SpeedV;

    [SerializeField] LaserPlayer spawn;

    private EnemyLVL1 enemy1;

    void Awake()
    {
        enemy1 = GameObject.FindObjectOfType<EnemyLVL1>();
    }

    void Update()
    {
        transform.Translate(0, -SpeedV * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
