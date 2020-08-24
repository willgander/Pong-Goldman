using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    //////////////////////////////////////////////
    //Assignment/Lab/Project: 
    //Name: William Goldman
    //Section: 2020FA
    //Instructor: Wold
    //Date: 8/17/20
    /////////////////////////////////////////////


    public Rigidbody2D rb2d;
    public float paddleSpeed;
    public float paddleBounds;
    

    public void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v)*paddleSpeed;
    }


    
}
