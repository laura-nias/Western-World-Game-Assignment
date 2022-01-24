using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Transform mainMenu, rulesMenu, highscoresMenu;

	// Use this for initialization
	public void StartGame () {
        SceneManager.LoadScene("game");
	}

    public void QuitGame()
    {
        Application.Quit();
    }
    public void RulesMenu(bool clicked)
    {
        if (clicked == true)
        {
            rulesMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            rulesMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }
    public void HighscoresMenu(bool clicked)
    {
        if (clicked == true)
        {
            highscoresMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            highscoresMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }
}
