using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDManager : MonoBehaviour
{
    //Create an enum to handle the different difficulty levels and set to easy by default
    public enum Difficulty { Easy, Medium, Hard };
    public Difficulty difficulty = Difficulty.Easy;

    //Variable to check if the game is running
    public bool gameOn = false;

    //Variable to hold the max number of rounds
    public int rounds = 3;

    //Game Object to contain all objects for this minigame
    public GameObject game;

    void Update()
    {
        //If gameOn is set to true, start the game
        //Then set gameOn to false to avoid infinite loops
        if (gameOn == true)
        {
            game.GetComponent<GDGame>().StartRound();
            gameOn = false;
        }
    }

    //Function to hold the switch case that handles the game difficulty
    public void StartGame()
    {
        //Add two more rounds for the increasing difficulties
        switch (difficulty)
        {
            case Difficulty.Easy:
                rounds = 3;
                break;
            case Difficulty.Medium:
                rounds = 5;
                break;
            case Difficulty.Hard:
                rounds = 7;
                break;
            default:
                rounds = 3;
                break;
        }
        gameOn = true;
        game.SetActive(true);
    }
}
