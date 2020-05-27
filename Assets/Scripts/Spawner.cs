using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Player player;


    private GameObject highestBox;
    private GameObject prevSpawnedBox;

    public float SpawnHeight = 10.0f;
    void Start()
    {
        Spawn();
        InvokeRepeating("Spawn", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Spawn()
    {
        float h = player.transform.position.y;
        if(highestBox)
        {
            if(highestBox.transform.position.y > h)
            {
                h = highestBox.transform.position.y;
            }
        }

        GameObject newBox = Instantiate(objectToSpawn);

        Vector2 SpawnLoc = new Vector2(UnityEngine.Random.Range(-2, 2), h + SpawnHeight);
        newBox.transform.position = SpawnLoc;
        newBox.transform.localScale = new Vector3(
            UnityEngine.Random.Range(1.0f, 3.0f), 
            UnityEngine.Random.Range(1.0f, 3.0f), 
            1.0f);
    }
}
