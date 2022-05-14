using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    //Variable reference to the wall prefab
    [SerializeField] GameObject walls;

    //Variables to handle timing for the wall spawning
    //This will prevent the walls from spawning too quickly
    private float timerDelay = 1.5f;
    private float lastEventTime;

    //Start is called before the first frame update
    void Start()
    {
        //Setup for the timer
        lastEventTime = Time.time - timerDelay;
    }

    // Update is called once per frame
    void Update()
    {
        //Check timer before calling the launch function
        if (Time.time >= lastEventTime + timerDelay)
        {
            //Spawn a wall set and destroy it after a set time
            GameObject wall = Instantiate(walls, new Vector3(walls.transform.position.x, walls.transform.position.y + Random.Range(-2, 2), walls.transform.position.z), walls.transform.rotation);
            Destroy(wall, 15);

            //Reset timer
            lastEventTime = Time.time;
        }
    }
}
