using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bricks : MonoBehaviour
{
    public int brickHP;
    bool daHit = false;
    int points;
    

    void Update()
    {
       
        if (daHit == true)
        {
            brickHP = brickHP - 1;
            points = points + 1;

            int sceneCount = SceneManager.GetActiveScene().buildIndex;

            if (brickHP == 2 && sceneCount == 1)
            {

                SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
                renderer.color = new Color(0.754717f, 0.6325461f, 0.6325461f, 1f);
                
            }
            else if (brickHP == 1 && sceneCount == 1)
            {
                SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
                renderer.color = new Color(0f, 16f, 43f, 25f);
            }
            else if (brickHP == 0)
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
