using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarabelleMove : MonoBehaviour
{
    //Get access to the player's transform
    private Transform tf;

    //Reference to the fire point child object to spawn the turtles
    public Transform firePoint;

    //Reference to the turtle that will be "launched" by the player
    //Turtle acts as a bullet of sorts
    public GameObject turtlePrefab;

    //Array of game objects to keep track of the player's positions
    public GameObject[] playerPositions = new GameObject[] { };

    //Variable to hold the index of player positions
    public int positionsIndex;

    //Variables to handle timing for the turtle launch
    //This will prevent the player from spamming the fire button to easily win
    public float timerDelay = 1.5f;
    public float lastEventTime;

    // Start is called before the first frame update
    void Start()
    {
        //Set tf equal to the game object's transform
        tf = gameObject.GetComponent<Transform>();

        //Setup for the timer
        lastEventTime = Time.time - timerDelay;
    }

    // Update is called once per frame
    void Update()
    {
        //Set Player controls

        //Move up with Up arrow or W key
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (positionsIndex < playerPositions.Length)
            {
                positionsIndex--;
                tf.position = playerPositions[positionsIndex].transform.position;
            }
            else if (positionsIndex > playerPositions.Length)
            {
                positionsIndex = 0;
            }
            else if (positionsIndex < 0)
            {
                positionsIndex = 0;
            }
        }

        //Move down with the down arrow or S key
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (positionsIndex < playerPositions.Length)
            {
                positionsIndex++;
                tf.position = playerPositions[positionsIndex].transform.position;
            }
            else if (positionsIndex > playerPositions.Length)
            {
                positionsIndex = 0;
            }
            else if (positionsIndex < 0)
            {
                positionsIndex = 0;
            }
        }

        //Let the player shoot when they press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Check timer before calling the launch function
            if (Time.time >= lastEventTime + timerDelay)
            {
                //Call the launch function
                LaunchTurtle();

                //Reset timer
                lastEventTime = Time.time;
            }
        }
    }

    //Function to launch the turtles
    public void LaunchTurtle()
    {
        Instantiate(turtlePrefab, firePoint.position, firePoint.rotation);
    }
}
