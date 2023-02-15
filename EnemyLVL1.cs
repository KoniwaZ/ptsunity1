using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyLVL1 : MonoBehaviour
{
    int speedV;

    void Start()
    {

    }

    void Update()
    {
        speedV = Random.Range(1, 2);
        transform.Translate(0, -speedV * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
