using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {
    public GameObject Explosion;
    public float moveSpeed = 0.5f;
    float enMoveSpeed = 20f;
    private Rigidbody2D _rb;

	void Start ()
    {
        if (!PlayerManager.isPlayerDead)
        {
            if (gameObject.tag == "HeroBullet")
            {
                var pos = Camera.main.WorldToScreenPoint(transform.position);
                var dir = Input.mousePosition - pos;
                _rb.velocity = new Vector2(dir.x * Time.deltaTime * moveSpeed, dir.y * Time.deltaTime * moveSpeed);
            }
            else
            {
                _rb.velocity = new Vector2(0, -enMoveSpeed);
            }
        }
        
	}

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (((other.tag == "Enemy") || (other.tag == "Dead")) && (gameObject.tag == "HeroBullet"))
        {
            GameObject Fire = (GameObject)Instantiate(Explosion, other.gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject, 0f);
            Destroy(Fire, 0.4f);
            if (other.tag == "Enemy")
            {
                other.tag = "Dead";
                Score.IncreaseScore();
                SpawnEnemy.DecreaseEnemiesOnScreen();
            }
        }
        if((other.tag =="Player")&&(gameObject.tag =="EnemyBullet"))
        {
            GameObject Fire = (GameObject)Instantiate(Explosion, other.gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject, 0f);
            Destroy(Fire, 0.4f);
            PlayerStats.DecreaseHealth();
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
