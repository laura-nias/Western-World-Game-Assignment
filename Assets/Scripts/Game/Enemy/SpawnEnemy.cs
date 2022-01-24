using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public GameObject eEnemyPrefab,hEnemyPrefab;
    GameObject enemy;

    public static int enemiesOnScreen = 0;
    public int maxEnemies = 5;
    float spawnDelay = 1;
    float timer;

	void Start () {
        InvokeRepeating("spawnRandEnemy", 0.8f, spawnDelay);
    }
	
	// Update is called once per frame
	void spawnRandEnemy () {
        bool playerDead = PlayerManager.isPlayerDead;

        if ((enemiesOnScreen < (maxEnemies+timer)) && (!playerDead))
        {
            int rand = Random.Range(0, 5);
            switch (rand)
            {
                case 0:
                    enemy = hEnemyPrefab;
                    Instantiate(enemy, new Vector3(Random.Range(-6f, 6f), 8, 0), Quaternion.identity);
                    break;
                default:
                    enemy = eEnemyPrefab;
                    Instantiate(enemy, new Vector3(Random.Range(-6f, 6f), 8, 0), Quaternion.identity);
                    break;
            }
            

            enemiesOnScreen++;
        }
	}
    void Update()
    {
        timer += Time.deltaTime;
    }

    public static void DecreaseEnemiesOnScreen()
    {
        if (enemiesOnScreen > 0)
            enemiesOnScreen--;
    }
}
