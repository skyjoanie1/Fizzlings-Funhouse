using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DLManager : MonoBehaviour
{

    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;

    public static DLManager Instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;

    // Start is called before the first frame update
    void Start()
    {
 
        Instance = this;
        scoreText.text = "Score: 0";
        currentMultiplier = 1;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!startPlaying)
        {
            

            if (Input.anyKeyDown)
            {
                // Start playing the game when any key is pressed
                startPlaying = true;
               // theBS.hasStarted = true; 
                

            }

        }
        
    }

    public void NoteHit()
    {

        Debug.Log("Hit On Time");

        if(currentMultiplier - 1 < multiplierThresholds.Length)
        {
            // Adds 1 to multiplierTracker
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                // Sets multiplierTracker to 0 if multiplerThreshold is <= multiplerTracker
                multiplierTracker = 0;
                // Adds 1 to current multiplier
                currentMultiplier++;

            }

        }

        // Will multiply scorePerNote & currentMultiplier to currentScore for normal hit
        currentScore += scorePerNote * currentMultiplier;

        // Update Multiplier Text
        multiText.text = "Multiplier: x" + currentMultiplier;
        
        // Update Score Text
        scoreText.text = "Score: " + currentScore;
        

    }

    /*
    public void NormalHit() 
    {
        // Will multiply scorePerNote & currentMultiplier to currentScore for normal hit
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();

    }
    public void GoodHit() 
    {
        // Will multiply scorePerGoodNote & currentMultiplier to currentScore for good hit
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();

    }
    public void PerfectHit() 
    {
        // Will multiply scorePerNote & currentMultiplier to currentScore for perfect hit
        currentScore += scorePerPerfectNote * currentMultiplier;
        NoteHit();

    }
    */


    public void NoteMissed()
    {

        Debug.Log("Missed Note");

        // Set currentMultiplier & multiplier tracker to 0 when a note is missed
        currentMultiplier = 1;
        multiplierTracker = 0;

        // Update Multiplier Text
        multiText.text = "Multiplier: x" + currentMultiplier;

    }

}
