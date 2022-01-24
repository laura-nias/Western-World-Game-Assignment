using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour {

    public GameObject extraHealthPrefab, lessHealthPrefab, invulnerablePrefab;
    GameObject powerUp;
	void Start () {
      
        InvokeRepeating("spawnRandPowerUp", 1.0f, 5.0f);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void spawnRandPowerUp()
    {
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                powerUp = extraHealthPrefab;
                break;
            case 1:
                powerUp = lessHealthPrefab;
                break;
            case 2:
                powerUp = invulnerablePrefab;
                break;
        }
        Instantiate(powerUp, new Vector3(Random.Range(-6f, 6f), 8, 0), Quaternion.identity);
    }
    
}
