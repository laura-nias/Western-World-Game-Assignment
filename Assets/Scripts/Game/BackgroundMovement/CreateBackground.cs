using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public GameObject tile_plainPrefab, tile_stone1Prefab, tile_stone2Prefab;
    GameObject tile;

    GameObject sideBuilding;
    public GameObject bankPrefab, innPrefab, saloonPrefab, SheriffsPrefab;

    public static Vector2 tileMapSize = new Vector2(5f, 4f);
    public const float tileWidth = 2.55f;

    int sideBuildSpawn = 10;
    int sideBuildLength = 3;
    void Start()
    {

        //Building Spawn
        for (int side = -sideBuildLength; side < sideBuildLength; side++)                   
        {
            getRandBuilding();                                                                                        //gets random number then insantiate a building
            Instantiate(sideBuilding, new Vector3(-sideBuildSpawn, side * sideBuildLength*2, 0), Quaternion.identity);
            getRandBuilding();      
            transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            Instantiate(sideBuilding, new Vector3(sideBuildSpawn, side * sideBuildLength *2, 0), transform.rotation);
        }


        //Tile Spawn
        for (float y = -tileMapSize.y; y <= tileMapSize.y; y++)
        {
            for (float x = -tileMapSize.x; x <= tileMapSize.x; x++)
            {
                int rand = Random.Range(0, 20);                         //goes through each row and column, picks a random number
                switch (rand)
                {                                                       //chooses a prefab to inisiate depending on the random number generated 
                    case 1:
                        tile = tile_stone1Prefab;
                        break;
                    case 2:
                        tile = tile_stone2Prefab;
                        break;
                    default:                                            //setting basic tile to default so there are more of them tiles
                        tile = tile_plainPrefab;
                        break;
                }
                Instantiate(tile, new Vector3(x * tileWidth, y * tileWidth, 0), Quaternion.identity);
            }
        }
    }


    void getRandBuilding()
    {
        int rand = Random.Range(1, 5);              //goes through each row and column, picks a random number
        switch (rand)
        {                                           //chooses a prefab to inisiate depending on the random number generated 
            case 1:
                sideBuilding = bankPrefab;          
                break;
            case 2:
                sideBuilding = innPrefab;
                break;
            case 3:
                sideBuilding = saloonPrefab;
                break;
            case 4:
                sideBuilding = SheriffsPrefab;
                break;
        }
    }
}
