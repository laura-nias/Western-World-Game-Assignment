using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hEnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Start()
    {
            InvokeRepeating("shoot", 1.0f, 5.0f);
    }
    void shoot()
    {

        if (!PlayerManager.isPlayerDead)
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0.2f, -1, 0), Quaternion.identity);
            Instantiate(bulletPrefab, transform.position - new Vector3(0.2f, 1, 0), Quaternion.identity);
        }

    }
}