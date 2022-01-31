using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASTStart : MonoBehaviour
{
    //Reference to the "game" Game Object
    public GameObject game;

    //Reference to the start arrows
    public GameObject starts;

    //Variable to handle the switch cases
    //Stands for: Easy, Medium, Hard
    public int eMH;

    //Set the difficulty level and start the game
    //Set default difficulty to easy
    public void Interaction()
    {
        switch (eMH)
        {
            case 1:
                game.GetComponent<ASTManager>().difficulty = ASTManager.Difficulty.Easy;
                game.GetComponent<ASTManager>().StartGame();
                break;
            case 2:
                game.GetComponent<ASTManager>().difficulty = ASTManager.Difficulty.Medium;
                game.GetComponent<ASTManager>().StartGame();
                break;
            case 3:
                game.GetComponent<ASTManager>().difficulty = ASTManager.Difficulty.Hard;
                game.GetComponent<ASTManager>().StartGame();
                break;
            default:
                game.GetComponent<ASTManager>().difficulty = ASTManager.Difficulty.Easy;
                game.GetComponent<ASTManager>().StartGame();
                break;
        }
        starts.SetActive(false);
    }
}
