using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //Variables Game Over UI
    public GameObject gameOverBackground;
    public Text gameOverText;

    //Variables for the hub button and play again buttons
    public GameObject hubButton;
    public int totalTools = 7;
    public Text toolsTotalText;
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
       
    }

    //Function to deactivate UI
    public void DeactivateUI()
    {
        gameOverBackground.SetActive(false);
        gameOverText.enabled = false;
        hubButton.SetActive(false);
    }

    public void Update()
    {
        toolsTotalText.text = "Points:" + GameManager.Instance.ToolsTotalPoints.ToString();
       
        if(GameManager.Instance.ToolsTotalPoints == totalTools)
        {
            ActivateUI();
        }
    }
}


