using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRManager : MonoBehaviour
{
    //Variable to keep track of point needed to win
    public int pointsToWin = 5;

    //Variable to access the points text to update UI
    public Text turtleRescuePointsText;

    //Variable to access the victory UI
    public GameObject victoryBackground;
    public Text victoryText;

    //Variable to access the game over UI
    public GameObject gameOverBackground;
    public Text gameOverText;

    //Variable reference to the Play Again and Hub buttons
    public GameObject playAgainButton;
    public GameObject hubButton;

    //Variable to access the countdown timer script
    public CountdownTimer cdt;


    void Start()
    {
        //Set the timescale to 1 when the game starts
        Time.timeScale = 1;

        //Disable the victory and game over UI on start
        victoryBackground.SetActive(false);
        victoryText.enabled = false;
        gameOverBackground.SetActive(false);
        gameOverText.enabled = false;
        playAgainButton.SetActive(false);
        hubButton.SetActive(false);

        //Gain access to the countdown timer script
        cdt = gameObject.GetComponent<CountdownTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Update the player's points and text constantly
        turtleRescuePointsText.text = "Points: " + GameManager.Instance.turtleRescuePoints.ToString(); 

        //Check timer and score to determine how the game ends
        if (cdt.currentTime <= 0)
        {
            //When the timer hits zero, pause the game in the background and activate the game over UI
            Time.timeScale = 0;
            gameOverBackground.SetActive(true);
            gameOverText.enabled = true;
            playAgainButton.SetActive(true);
            hubButton.SetActive(true);
        }
        else if (GameManager.Instance.turtleRescuePoints >= pointsToWin && cdt.currentTime > 0)
        {
            //If the player gets enough points to win and the timer hasn't ended, 
            //set the timescale to zero and enable the victory UI
            Time.timeScale = 0;
            victoryBackground.SetActive(true);
            victoryText.enabled = true;
            playAgainButton.SetActive(true);
            hubButton.SetActive(true);
        }
    }
}
