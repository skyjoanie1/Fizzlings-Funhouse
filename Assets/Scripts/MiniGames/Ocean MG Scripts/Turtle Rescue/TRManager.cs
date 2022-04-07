using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRManager : MonoBehaviour
{
    //Variable to keep track of point needed to win
    public int pointsToWin = 5;

    //Variable to keep track of points
    public int pointsTurtles;

    //Variable to access the points text to update UI
    public Text turtleRescuePointsText;

    public GameObject GameOverScreen;

    public GameObject VictoryScreen;

    //Variable to access the countdown timer script
    public CountdownTimer cdt;


    void Start()
    {
        //Set the timescale to 1 when the game starts
        Time.timeScale = 1;

        //Disable the victory and game over UI on start
        GameOverScreen.SetActive(false);
        VictoryScreen.SetActive(false);

        pointsTurtles = 0;

        //Gain access to the countdown timer script
        cdt = gameObject.GetComponent<CountdownTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Update the player's points and text constantly
        turtleRescuePointsText.text = "Points: " + pointsTurtles; 

        //Check timer and score to determine how the game ends
        if (cdt.currentTime <= 0)
        {
            //When the timer hits zero, pause the game in the background and activate the game over UI
            GameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else if (pointsTurtles >= pointsToWin && cdt.currentTime > 0)
        {
            //If the player gets enough points to win and the timer hasn't ended, 
            //set the timescale to zero and enable the victory UI
            VictoryScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
