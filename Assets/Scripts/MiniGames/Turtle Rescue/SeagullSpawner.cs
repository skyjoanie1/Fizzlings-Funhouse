using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullSpawner : MonoBehaviour
{
    //Variable reference to the seagull prefab
    public GameObject seagullPrefab;

    //Array to access the seagull spawner game objects
    public GameObject[] seagullSpawners = new GameObject[] { };

    //Variable to handle the index of spawners array
    public int seagullSpawnersIndex = 0;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.numSeagulls < 2)
        {
            SpawnSeagull();
        }
    }

    //Function to spawn the seagulls
    public void SpawnSeagull()
    {
        int randSpawnPoint = Random.Range(0, seagullSpawners.Length);

        Instantiate(seagullPrefab, seagullSpawners[randSpawnPoint].transform.position, transform.rotation);

        GameManager.Instance.numSeagulls++;
    }
}
