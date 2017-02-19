using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public Transform MainMenu, WinMenu, LoseMenu;

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void winnerLevel(bool clicked)
    {
        if(clicked == true)
        {
            MainMenu.gameObject.SetActive(clicked);
            WinMenu.gameObject.SetActive(false);
        } else
        {
            MainMenu.gameObject.SetActive(clicked);
            WinMenu.gameObject.SetActive(true);
        }
    }

    public void loseLevel(bool clicked)
    {
        if (clicked == true)
        {
            MainMenu.gameObject.SetActive(clicked);
            LoseMenu.gameObject.SetActive(false);
        }
        else
        {
            MainMenu.gameObject.SetActive(clicked);
            LoseMenu.gameObject.SetActive(true);
        }
    }
}
