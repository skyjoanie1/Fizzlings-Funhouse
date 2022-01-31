using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDStart : MonoBehaviour
{
    //Reference to the manager Game Object
    public GameObject manager;

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
                manager.GetComponent<GDManager>().difficulty = GDManager.Difficulty.Easy;
                manager.GetComponent<GDManager>().StartGame();
                break;
            case 2:
                manager.GetComponent<GDManager>().difficulty = GDManager.Difficulty.Medium;
                manager.GetComponent<GDManager>().StartGame();
                break;
            case 3:
                manager.GetComponent<GDManager>().difficulty = GDManager.Difficulty.Hard;
                manager.GetComponent<GDManager>().StartGame();
                break;
            default:
                manager.GetComponent<GDManager>().difficulty = GDManager.Difficulty.Easy;
                manager.GetComponent<GDManager>().StartGame();
                break;
        }
        starts.SetActive(false);
    }
}
