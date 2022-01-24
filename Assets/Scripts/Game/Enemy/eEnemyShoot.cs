using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eEnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Start()
    {
        InvokeRepeating("shoot", 1.0f, 5.0f);       //Repeates the function shoot with a delay
    }
    void shoot()
    {
        if (!PlayerManager.isPlayerDead)
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}