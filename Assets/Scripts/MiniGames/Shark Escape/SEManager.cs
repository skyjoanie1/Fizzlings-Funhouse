using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEManager : MonoBehaviour
{
    //Variable access to the Canvas
    public Canvas canvas;

    //Variables to access the victory UI
    public GameObject victoryBackground;
    public Text victoryText;

    //Variables to access the game over UI
    public GameObject gameOverBackground;
    public Text gameOverText;

    //Variable to access the Play Again and Hub button
    public GameObject playAgainButton;
    public GameObject hubButton;

    // Start is called before the first frame update
    void Start()
    {
        //Set the timescale to 0 when the game starts
        Time.timeScale = 1;

        //Enable the start menu UI
        canvas.enabled = false;

        //Disable the victory and game over UI on start
        victoryBackground.SetActive(false);
        victoryText.enabled = false;
        gameOverBackground.SetActive(false);
        gameOverText.enabled = false;
        playAgainButton.SetActive(false);
        hubButton.SetActive(false);
    }

    
}
