using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public int maxHealth=3;
    public static int health;
    public GameObject GameOverPrefab;
    public bool alive;
    public Text Health;


	void Start () {
        health = maxHealth;
        
	}
    public static void DecreaseHealth()
    {
        if(!PowerUps.isInvulnerable)                //decreases the game objects health
            health--;
    }
    public static void IncreaseHealth()
    {
        if (!PowerUps.isInvulnerable)
            health++;
    }
    
	// Update is called once per frame
	void Update () {
        if (health == 0)
        {
            PlayerPrefs.Save();                     //saves score when player dies
            PlayerManager.PlayerDied();

        }
    }
    void LateUpdate()
    {
        Health.text = "Health: " + health;          //updates health on UI
    }

}
