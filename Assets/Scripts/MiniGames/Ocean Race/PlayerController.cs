using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Variable reference to the UI controller
    public ORUIController uiController;

    //Variable to hold the score text
    [SerializeField] TextMeshProUGUI scoreText;

    //Variable access to the rigidbody2d
    Rigidbody2D marabelle;

    //Variable to keep track of the player's score
    int score = 0;

    //Variable to check if the player is dead or not
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        marabelle = transform.GetComponent<Rigidbody2D>();
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Check for user input
        if (Input.GetKeyDown("space") && !dead)
        {
            marabelle.velocity = new Vector2(0, 8.5f);
        }

        //Restart the game when the user presses 'r'
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //Check for collisions
    void OnCollisionEnter2D()
    {
        //Set the timescale to 0 so more walls don't spawn in the background
        Time.timeScale = 0;

        //"Kill" the player when the touch an object
        dead = true;

        //Activate the game over UI
        uiController.ActivateUI();
    }

    //Check for trigger
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Point Trigger")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
