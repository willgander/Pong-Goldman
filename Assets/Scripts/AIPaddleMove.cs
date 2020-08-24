using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddleMove : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float paddleSpeed;
    public float paddleBounds;
    public Transform target;
    public Transform AiPos;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        if(target.position.y > AiPos.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2) * paddleSpeed;
        }
        else if(target.position.y < AiPos.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -2) * paddleSpeed;
        }
    }
}
