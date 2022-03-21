using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI WinText;
    void Update()
    {
        int sceneCount = SceneManager.GetActiveScene().buildIndex;

        
        if (GameObject.FindGameObjectsWithTag("Brick").Length <= 0 && sceneCount < 3)
        {
            WinText.text = "You Win\nPress space to next level";
            Time.timeScale = 0;
            if (Input.GetKey("space"))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            
        }
        else if (GameObject.FindGameObjectsWithTag("Brick").Length <= 0 && sceneCount == 3)
        {
            WinText.text = "You Win\nPress esc to menu";
            Time.timeScale = 0;
            if (Input.GetKey("escape"))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }

    }
}
