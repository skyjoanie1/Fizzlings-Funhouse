using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ORUIController : MonoBehaviour
{
    //Variables Game Over UI
    public GameObject gameOverBackground;
    public Text gameOverText;

    //Variables for the hub button and play again buttons
    public GameObject hubButton;
    public GameObject playAgainButton;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateUI();
    }

    //Function to activate UI
    public void ActivateUI()
    {
        gameOverBackground.SetActive(true);
        gameOverText.enabled = true;
        hubButton.SetActive(true);
        playAgainButton.SetActive(true);
    }

    //Function to deactivate UI
    public void DeactivateUI()
    {
        gameOverBackground.SetActive(false);
        gameOverText.enabled = false;
        hubButton.SetActive(false);
        playAgainButton.SetActive(false);
    }

}
