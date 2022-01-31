using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    //Button to load the Main Menu from the Options Menu
    public void ReturnButton()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
