using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int brickHP = 1;
    bool daHit = false;
    
    void Update()
    {
        if (daHit == true)
        {
            int dmgBrick = brickHP - 1;
            brickHP = dmgBrick;
            if (brickHP == 0)
            {
                Destroy(this.gameObject);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            daHit = true; 
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            daHit = false;
        }
    }
}
