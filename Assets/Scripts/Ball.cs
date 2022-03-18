using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb2DBall;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,float racketWidth)
    {
        
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       
        float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

        
        Vector2 dir = new Vector2(x, 1).normalized;

        
        GetComponent<Rigidbody2D>().velocity = dir * speed;

        
    }
}
