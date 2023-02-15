using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] int jump;

    [SerializeField] GroundChecker groundCheck;

    [SerializeField] Text scoreText;
    [SerializeField] Text lifeText;
    [SerializeField] Text notifText;
    [SerializeField] Text lastText;

    [SerializeField] Button restartButton;
    [SerializeField] Button mainmenuButton;
    [SerializeField] Button nextstageButton;

    [SerializeField] GameObject treasure;

    Rigidbody2D rb;
    public Animator animator;

    bool isWin;

    private int score;
    private int life;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isWin = false;
        score = 0;
        life = 3;
        scoreText.text = "Score : " + score;
        lifeText.text = life +" : Life";
        notifText.gameObject.SetActive(false);
        lastText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        mainmenuButton.gameObject.SetActive(false);
        nextstageButton.gameObject.SetActive(false);

    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", MathF.Abs(x));

        if(groundCheck.isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.transform.position.x,jump);
                groundCheck.isGround = false;
                animator.SetBool("IsJumping", true);
            }
            animator.SetBool("IsJumping", false);
            
        }
        rb.AddForce(new Vector2(x, 0));
        rb.velocity = new Vector2(x* speed * Time.deltaTime, rb.velocity.y) ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PickUps"))
        {
            if (!isWin)
            {
                score++;
                scoreText.text = "Score : " + score;
                Destroy(collision.gameObject);
            }
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            if(!isWin)
            {
                isWin = true;
                Succes();
            }
        }
        if(collision.gameObject.CompareTag("Traps"))
        {
            if(!isWin)
            {
                life--;
                lifeText.text = life + " : Life";
                //transform.position = new Vector3(-8, -1,1 );
                if(life <= 0)
                {
                    life = 0;
                    Fail();
                }
            }
        }
    }

    private void Succes()
    {
        lastText.text = "Score : " + score;
        notifText.text = "Stage 1 Completed!!!";
        notifText.gameObject.SetActive(true);
        lastText.gameObject.SetActive(true);
        mainmenuButton.gameObject.SetActive(true);
        nextstageButton.gameObject.SetActive(true);
        treasure.gameObject.SetActive(false);
    }
    
    private void Fail()
    {
        lastText.text = "Score : " + score;
        notifText.text = "Game Over!!!";
        notifText.gameObject.SetActive(true);
        lastText.gameObject.SetActive(true);
        mainmenuButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
