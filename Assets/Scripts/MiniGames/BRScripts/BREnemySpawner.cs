using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BREnemySpawner : MonoBehaviour
{

    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public GameObject[] spawningList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // Instantiate(spawningList[1], transform.position, Quaternion.identity);

        if (Time.time > nextSpawn)
        {

            nextSpawn = Time.time + spawnRate;
            Instantiate(spawningList[0], transform.position, Quaternion.identity);


        }

    }
}
