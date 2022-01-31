using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuFuctions : MonoBehaviour
{
    //Button to load the Main Scene from the Main Menu
    public void Play_Button()
    {
        SceneManager.LoadScene("Hub");
    }

    //Button to load the Options Menu Scene
    public void Options_Button()
    {
        SceneManager.LoadScene("Options Menu");
    }

    //Button to quit the game from the Main Menu
    public void Quit_Button()
    {
        Application.Quit();
    }
}
