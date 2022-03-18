using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject MenuInit;
    public GameObject LevelsMenu;
    public Button BackOne;
    void PlayGame()
    {

        SceneManager.LoadScene(1);

    }
    void LevelsButton()
    {

        MenuInit.SetActive(false);
        LevelsMenu.SetActive(true);

    }

}
