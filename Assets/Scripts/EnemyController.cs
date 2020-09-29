using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed = 1.75F;

    //the ball
    Transform ball;

    //the ball's rigidbody 2D
    Rigidbody2D ballRig2D;

    //bounds of enemy
    public float topBound = 4.5F;
    public float bottomBound = -4.5f;


    void FixedUpdate()
    {
        //finding the ball
        ball = GameObject.FindGameObjectWithTag("Ball").transform;

        //setting th eball's rigidbody to a variable
        ballRig2D = ball.GetComponent<Rigidbody2D>();

        //checking x direction of the ball
        if (ballRig2D.velocity.x < 0)
        {
            //checking y direction of ball
            if (ball.position.y < this.transform.position.y)
            {
                //move ball down if lower than paddle
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            } else if (ball.position.y < this.transform.position.y)
            {
                //move ball up if higher than paddle
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }

        //set bound sof enemy
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        } else if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    
    }



}
