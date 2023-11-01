using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    public float tileLength = 30;
    public int numberOfTiles = 5;

    public float zSpawn = 0;

    public Transform playerTransform;

    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if(i==0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }

    }
    void Update()
    {
        if(playerTransform.position.z > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, numberOfTiles));
        }
            
    }

    public void SpawnTile(int index)
    {
        Instantiate(tilePrefabs[index], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }
}