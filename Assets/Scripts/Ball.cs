using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public KeyCode serve;

    public float playerScore;
    public Text playerScoreText;
    public float AIScore;
    public Text AIScoreText;

    [Header("Panels")]
    public GameObject winPanel;
    public GameObject losePanel;

    


    private Rigidbody2D rb2d;
    public float speed;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
        
    }

    private void Update()
    {
        playerScoreText.text = playerScore.ToString();
        AIScoreText.text = AIScore.ToString();

        if(Input.GetKey(serve))
        {
            BallStart();
        }

        if(AIScore >= 10)
        {
            GameLost();
        }
        if(playerScore >= 10)
        {
            GameWin();
        }
    }

    private void BallStart()
    {
        rb2d.AddForce(new Vector2(-20, -15) * speed);

       
    }

    private void BallPause()
    {
        
        //Can't get the ball to stop moving.
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerGoal"))
        {
            AIScore++;
            transform.position = new Vector2(6.5f, 0f);
            BallPause();
        }
        else if (collision.gameObject.CompareTag("AIGoal"))
        {
            playerScore++;
            transform.position = new Vector2(6.5f, 0f);
            BallPause();
        }
    }

    public void GameLost()
    {
        losePanel.gameObject.SetActive(true);
    }

    public void GameWin()
    {
        winPanel.gameObject.SetActive(true);
    }
}
