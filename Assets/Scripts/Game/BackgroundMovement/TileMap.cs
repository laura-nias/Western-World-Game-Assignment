using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {
    float tileWidth; 
    const float aboveScreen = 8.94f;

    private void Awake()
    {
        tileWidth = CreateBackground.tileWidth;             //gets tileWidth from createBackground class were it is first decleared
    }

    void Start () {
        
    }
	
	void Update () {

        if(!PlayerManager.isPlayerDead)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.08f, gameObject.transform.position.z); //tiles move down the map

    }
    void OnBecameInvisible()
    {
        if (gameObject.transform.position.y < 0)        
        {
            transform.position = new Vector3(gameObject.transform.position.x, aboveScreen, 0);              //moves the gameObject back up to the top of the map     
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag =="Tile")
        {
            if(gameObject.transform.position.y > collision.collider.transform.position.y)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + (2*tileWidth), 0);       //pushes tile up on the y to make sure no tile collided
            }
        }
    }
}
