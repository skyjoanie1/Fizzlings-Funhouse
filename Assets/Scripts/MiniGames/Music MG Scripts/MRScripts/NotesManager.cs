using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NotesManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;
    public NotesTempo theBS;

    public static NotesManager instance;

    public int currentScore;
    public int scorePerNote;
    public int maxScore;

    public int currentMissScore;
    public int missPerNote;
    public int maxMissScore;

    public GameObject gameOverBackground;
    public Text gameWinText;
    public Text scoreText;
    
    public GameObject GameLosebackground;
    public Text MissText;
    public Text missScoreText;



    

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "Score: 0";
        DeactivateWinUI();
        DeactivateLossUI();
        missScoreText.text = "Missed: 0";
        
    }
    public void ActivateWinUI()
    {
        gameOverBackground.SetActive(true);
        gameWinText.enabled = true;
       // hubButton.SetActive(true);

    }
    public void ActivateLossUI()
    {
        GameLosebackground.SetActive(true);
        MissText.enabled = true;
        // hubButton.SetActive(true);

    }
    public void DeactivateWinUI()
    {
        gameOverBackground.SetActive(false);
        gameWinText.enabled = false;
        //hubButton.SetActive(false);
    }
    public void DeactivateLossUI()
    {
        GameLosebackground.SetActive(false);
        MissText.enabled = false;
        //hubButton.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }

        if(currentScore == maxScore)
        {
            ActivateWinUI();
            
        }
        if(currentMissScore == maxMissScore)
        {
            ActivateLossUI();
        }

    }
    public void NoteHit()
    {
        Debug.Log("Hite");
        currentScore += scorePerNote;
        scoreText.text = "Score:" + currentScore;
    }
    public void NoteMiss()
    {
        Debug.Log("Miss");
        currentMissScore += missPerNote;
        missScoreText.text = "Missed:" + currentMissScore;
    }
}
