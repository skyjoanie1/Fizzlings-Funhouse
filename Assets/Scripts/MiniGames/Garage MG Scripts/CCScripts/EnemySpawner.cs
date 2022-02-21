using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] spawningList;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time > nextSpawn)
        {
            int randomNum = Random.Range(0, 2);
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-6f, 6f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(spawningList[randomNum], whereToSpawn, Quaternion.identity);


        }

        

    }
}
