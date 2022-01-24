using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBuilding : MonoBehaviour
{
    float buildingWidth = 8f;
    float aboveScreen = 10.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManager.isPlayerDead)
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.08f, 1);    //scrolls buildings down
    }
    void OnBecameInvisible()
    {
        transform.position = new Vector3(transform.position.x, aboveScreen, 1);         //moves building back up to the top of the screen 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Building")
        {
            if (gameObject.transform.position.y > collision.collider.transform.position.y)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + (buildingWidth), 0); //pushes buildings up on the y to make sure no buildings collided
            }
        }
    }
}
