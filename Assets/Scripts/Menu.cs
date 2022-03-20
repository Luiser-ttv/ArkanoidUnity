using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject MenuInit;
    public GameObject LevelsMenu;
    public void PlayGame()
    {

        SceneManager.LoadScene(1);

    }
    public void LevelsButton()
    {

        MenuInit.SetActive(false);
        LevelsMenu.SetActive(true);

    }
    public void BackButton()
    {
        MenuInit.SetActive(true);
        LevelsMenu.SetActive(false);
    }
    public void LevelTwo()
    {

        SceneManager.LoadScene(2);

    }
    public void LevelThree()
    {

        SceneManager.LoadScene(3);

    }

}
