using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {
    public GameObject gameoverScreen;
    PlayerManager instance;
    public static bool isPlayerDead;

	void Start () {
        isPlayerDead = false;
        gameoverScreen.SetActive(false);
	}

    void Awake()
    {
        Debug.Assert(instance == null);     
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
		if(isPlayerDead == true)
        {
            gameoverScreen.SetActive(true);         //starts game over screen when player dies
        }

	}
    public static void PlayerDied()
    {
        isPlayerDead = true;
        
    }
    public void Restart() {
        SceneManager.LoadScene("game");             //restarts the whole game
        gameoverScreen.SetActive(false);            //removes game over screen

    }
    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");            //starts Main menu screen
    }
}
