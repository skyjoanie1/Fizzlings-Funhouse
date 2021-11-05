using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;

//Game Manager handles a lot of behind the scenes management (hence the name)
//It also inherits from Singleton
public class GameManager : Singleton<GameManager>
{
    //Create an array of rooms for organization and transitions
    public GameObject[] rooms;

    //Create a variable to assign a number to the current room
    public int currRoom = 1;

    //Game Object to recognize the player and interact with them
    public GameObject player;


    //Turtle Rescue Game Variables
    //Variable to handle points earned from the Turtle Rescue Game
    public int turtleRescuePoints = 0;

    //Variable to handle the number of seagulls in the Turtle Rescue scene
    public int numSeagulls = 0;
    //tool organizer game
    //variable to tell the total numnber of tools placed
    public int ToolsTotalPoints = 0;

    //Override the Awake function from Singleton
    protected override void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a current scene variable and set the active scene equal to it
        Scene currentScene = SceneManager.GetActiveScene();

        //Set the current scene's name
        string sceneName = currentScene.name;

        //Check for the "Main" scene and set the player's transform to the current room
        //Reset the current room position to the new current room
        if (sceneName == "Main")
        {
            Vector3 currRoomPos = new Vector3(rooms[currRoom - 1].transform.position.x, player.transform.position.y, player.transform.position.z);
            player.transform.position = currRoomPos;
        }
    }
}