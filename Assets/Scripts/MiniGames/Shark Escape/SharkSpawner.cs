using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    //Variable reference to the shark prefab
    public GameObject sharkPrefab;

    //Variable to make sure there is only one shark at a time
    public int numShark;

    //Timer variables
    public float currentTime = 0f;
    public float startingTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //Reset timer
        currentTime = startingTime;

        //Disable the shark on start so the player has a chance to escape it
        sharkPrefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Have the timer count down
        currentTime -= 1 * Time.deltaTime;

        //When the timer hits zero, reset
        if (currentTime <= 0)
        {
            currentTime = 0;
            
            //Make sure only one Shark at any given time
            if (numShark < 1)
            {
                SpawnShark();
                numShark = 1;
            }
        }
    }

    //Enable Shark at the end of the timer
    public void SpawnShark()
    {
        sharkPrefab.SetActive(true);
    }
}
