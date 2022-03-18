using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedPlayer = 2;

    Rigidbody2D rb2DPlayer;

    void Start()
    {
        rb2DPlayer = gameObject.GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        MovPlayer();


    }

    void MovPlayer()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2DPlayer.velocity = new Vector2(speedPlayer, rb2DPlayer.velocity.y);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2DPlayer.velocity = new Vector2(-speedPlayer, rb2DPlayer.velocity.y);

        }
        else
        {
            rb2DPlayer.velocity *= new Vector2(0, rb2DPlayer.velocity.y);
        
        }
    }
}
   
