using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SEMenu : MonoBehaviour
{
    //Variable to hold the chosen scene
    public string sceneToLoad;

    //Variable access to the Canvas
    public Canvas canvas;

    //Variables to access the start menu UI
    public GameObject menuBackground;
    public Text menuText;

    //Variable reference to the dropdown object
    public Dropdown dropdown;

    //Variable to access the Play, Play Again, and Hub button
    public GameObject playButton;
    public GameObject hubButton;

    //Start is called before the first frame update
    void Start()
    {
        //Set timescale to 0
        Time.timeScale = 0;

        //Enable the start menu screen
        menuBackground.SetActive(true);
        menuText.enabled = true;
        playButton.SetActive(true);
        dropdown.enabled = true;
        canvas.enabled = true;
    }

    //Start the game when called
    public void PlayGame()
    {
        //Set the timescale to 1
        Time.timeScale = 1;

        //Disable the start menu UI
        menuBackground.SetActive(false);
        menuText.enabled = false;
        playButton.SetActive(false);
        dropdown.enabled = false;
        dropdown.Hide();
        canvas.enabled = false;

        //Load the scene for the chosen difficulty
        SceneManager.LoadScene(sceneToLoad);
    }

    //Adjust the maze based on player's choice
    public void ChooseDifficulty(int index)
    {
        switch (index)
        {
            case 1:
                sceneToLoad = "Shark Escape Easy";
                break;
            case 2:
                sceneToLoad = "Shark Escape Medium";
                break;
            case 3:
                sceneToLoad = "Shark Escape Hard";
                break;
            default:
                sceneToLoad = "Shark Escape Easy";
                break;
        }
    }
}
