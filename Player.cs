using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Vector3 touchPosition;
    Vector3 direction;

    [SerializeField] int speed;

    [SerializeField] Text ScoreText;

    Rigidbody2D rb;

    private int totalScore;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        totalScore = 0;
        ScoreText.text = "Score : 0";
    }
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x, y) * speed;

        /*if (Input.touchCount > 0)
        {
            if(Input.touchCount < 2)
            {
                Touch touch = Input.GetTouch(0);
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
                direction = (touchPosition - transform.position);
                rb.velocity = new Vector2(direction.x, direction.y) * speed;
                if(touch.phase ==  TouchPhase.Ended)
                {
                    rb.velocity = Vector2.zero;
                }
            }
        }*/
    }
 
    public void UpdateScore(int score)
    {
        totalScore += score;
        ScoreText.text = "Score : " + totalScore;
    }
}
