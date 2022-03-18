using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DeadWall : MonoBehaviour
{
    public GameObject SecondBall;
    public GameObject ThirdBall;
    public GameObject Racket;
    public TextMeshProUGUI LifeScorer;
    public TextMeshProUGUI DeadText;
    int Lifes = 3;
    
    void Update()
    {
        if (Lifes == 2)
        {
            SecondBall.SetActive(true);
            LifeScorer.text = "HP: 2";
            //Racket.transform.position = new Vector2(0,-4);
        }
        else if (Lifes == 1)
        {
            ThirdBall.SetActive(true);
            LifeScorer.text = "HP: 1";
            //Racket.transform.position = new Vector2(0, -4);
        }
        else if (Lifes == 0)
        {
            DeadText.text = "You Lose\nPress Space to restart or esc to menu";
            if (Input.GetKey("space"))
            {
                SceneManager.LoadScene(1);
            }
            else if (Input.GetKey("escape"))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            Lifes = Lifes - 1;
            

        }
    }
}
