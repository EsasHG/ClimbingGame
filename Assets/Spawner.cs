using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectToSpawn;
    public Player player;

    public float SpawnHeight = 5.0f;
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
        Debug.Log("Test");
        GameObject newBox = Instantiate(ObjectToSpawn);
        Vector2 SpawnLoc = new Vector2(UnityEngine.Random.Range(-2, 2),player.transform.position.y + SpawnHeight);
        newBox.transform.position = SpawnLoc;
    }
}
