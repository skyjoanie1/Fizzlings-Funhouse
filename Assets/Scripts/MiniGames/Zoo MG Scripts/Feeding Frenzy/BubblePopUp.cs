using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePopUp : MonoBehaviour
{
    //is the gameobjet it is storing
    public GameObject spawnee;
    //checks to see if it stop spawning
    public bool stopSpawning = false;
    //gets a time for it to spawn
    public float spawnTime;
    //how long the delay will be to spawn
    public float spawnDelay;

    

    void Start()
    {
        spawnDelay = Random.Range(10f, 15f) + spawnTime;
        //will keep calling the function to spawn the time and how long to wait to spawn again. 
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
       
    }
    //will spawn the object that is it storing. 
    public void SpawnObject()
    {
        //create the object and spawn it in game
        Instantiate(spawnee, transform.position, transform.rotation);


        //if there is a object curretly spawned then stop spawning. 
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
     
    }
}
