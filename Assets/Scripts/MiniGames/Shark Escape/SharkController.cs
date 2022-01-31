using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    //Variable reference to the SEManager
    public SEManager manager;

    //Destroy the player when colliding and show the game over screen
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        manager.canvas.enabled = true;
        manager.gameOverBackground.SetActive(true);
        manager.gameOverText.enabled = true;
        manager.playAgainButton.SetActive(true);
        manager.hubButton.SetActive(true);
    }
}
