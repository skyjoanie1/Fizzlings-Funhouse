using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DLGameManager : MonoBehaviour
{

    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;

    public static GameManager Instance;

    public int currentScore;
    public int CPUcurrentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;

    public int currentMultiplier;
    public int multiplierTracker;
    public int CPUcurrentMultiplier;
    public int CPUmultiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;

    public Text CPUscoreText;
    public Text CPUmultiText;

    public int cpuNum;

    // Start is called before the first frame update
    void Start()
    {

        
        scoreText.text = "Score: 0";
        currentMultiplier = 1;
        CPUscoreText.text = "CPU Score: 0";
        CPUcurrentMultiplier = 1;

        cpuNum = Random.Range(1, 3);

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
                theBS.hasStarted = true; 
                

            }

        }
        
    }

    public void NoteHit()
    {

        //Debug.Log("Hit On Time");

        // Will multiply scorePerNote & currentMultiplier to currentScore for normal hit
        currentScore += scorePerNote * currentMultiplier;

        // Update Multiplier Text
        multiText.text = "Multiplier: x" + currentMultiplier;
        
        // Update Score Text
        scoreText.text = "Score: " + currentScore;

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



        
        

    }

    public void CPUNoteHit()
    {

        //Debug.Log("Hit On Time");

        // Will multiply scorePerNote & currentMultiplier to currentScore for normal hit
        CPUcurrentScore += scorePerNote * CPUcurrentMultiplier;

        // Update Multiplier Text
        CPUmultiText.text = "CPU Multiplier: x" + CPUcurrentMultiplier;
        
        // Update Score Text
        CPUscoreText.text = "CPU Score: " + CPUcurrentScore;

        if(CPUcurrentMultiplier - 1 < multiplierThresholds.Length)
        {
            // Adds 1 to multiplierTracker
            CPUmultiplierTracker++;

            if (multiplierThresholds[CPUcurrentMultiplier - 1] <= CPUmultiplierTracker)
            {
                // Sets multiplierTracker to 0 if multiplerThreshold is <= multiplerTracker
                CPUmultiplierTracker = 0;
                // Adds 1 to current multiplier
                CPUcurrentMultiplier++;

            }

        }



        
        

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

    public void CPUNoteMissed()
    {

        Debug.Log("Missed Note");

        // Set currentMultiplier & multiplier tracker to 0 when a note is missed
        CPUcurrentMultiplier = 1;
        CPUmultiplierTracker = 0;

        // Update Multiplier Text
        CPUmultiText.text = "CPU Multiplier: x" + CPUcurrentMultiplier;

    }



}
