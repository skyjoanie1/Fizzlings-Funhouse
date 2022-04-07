using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullSpawner : MonoBehaviour
{
    //Variable reference to the seagull prefab
    public GameObject seagullPrefab;
    float randXPos;
    public Vector3 whereToSpawnSeagull;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;


    // Update is called once per frame
    void Update()
    {

        //Function to spawn the seagulls
        if (Time.time > nextSpawn)
        {
            int randomNum = Random.Range(0, 2);
            nextSpawn = Time.time + spawnRate;
            randXPos = Random.Range(-14f, 10f);
            whereToSpawnSeagull = new Vector3(randXPos, transform.position.y, -2);
            Instantiate(seagullPrefab, whereToSpawnSeagull, Quaternion.identity);


        }
    }

   
}
