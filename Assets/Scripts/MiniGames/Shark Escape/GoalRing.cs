using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRing : MonoBehaviour
{
    //Variable reference to the SEManager
    public SEManager manager;

    //When the player enters the goal ring, activate the victory UI from the SEManager
    void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;

        manager.canvas.enabled = true;
        manager.victoryBackground.SetActive(true);
        manager.victoryText.enabled = true;
        manager.playAgainButton.SetActive(true);
        manager.hubButton.SetActive(true);
    }
}
