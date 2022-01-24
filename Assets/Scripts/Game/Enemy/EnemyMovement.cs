using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    public Vector2 moveSpeed = new Vector2(120, 120);
    public float farTop = 0, farBot = 0, farLeft = 0, farRight = 0;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Enemy")                          //makes sure enemy is alive
        {
            if (transform.position.x <= farLeft)                                    //Checks boundaries
            {
                moveSpeed.x = -moveSpeed.x;                                         //bounces of boundaries
                transform.position = new Vector2(farLeft, transform.position.y);
            }
            if (transform.position.x >= farRight)
            {
                moveSpeed.x = -moveSpeed.x;
                transform.position = new Vector2(farRight, transform.position.y);
            }


            if (transform.position.y <= farBot)
            {
                moveSpeed.y = -moveSpeed.y;
                transform.position = new Vector2(transform.position.x, farBot);
            }
            if (transform.position.y >= farTop)
            {
                moveSpeed.y = -moveSpeed.y;
                transform.position = new Vector2(transform.position.x, farTop);
            }
        }


        if(gameObject.tag == "Untagged")
        {
            if (transform.position.y < farTop)
            {
                gameObject.tag = "Enemy";
                moveSpeed.x = ((Random.Range(0, 2)*2)-1)*100;               //gets random direction of speed
                moveSpeed.y = ((Random.Range(0, 2) * 2) - 1) * 100;
            }
            else
                moveSpeed = new Vector3(0, -120, 0);                        //moves enemy onto screen
        }



        _rb.velocity = moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HeroBullet")
            Destroy(this.gameObject);                   //destroies the enemy if it is hit by a heros bullet
                
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag =="Enemy")
            moveSpeed = -moveSpeed;                     //bounces of when the object collides with another enemy
        
    }

    void OnBecameInvisible()
    {
        if(gameObject.tag =="Dead")
            Destroy(gameObject);                        //removes enemy if out of sight and dead

    }
}
