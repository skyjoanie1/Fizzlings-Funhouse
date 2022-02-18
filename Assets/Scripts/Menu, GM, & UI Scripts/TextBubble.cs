using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBubble : MonoBehaviour
{
    //Variable for the text bubble duration
    public float bubbleTimer = 5.0f;

    //Game Image to hold the text bubble itself
    public Image textBubble;

    //Variable to hold the audio clip
    public AudioClip audioClip;

    //Disable textBubble on Awake so it doesn't appear until clicked
    void Awake()
    {
        textBubble.enabled = false;
    }

    //Function to display the text bubble with the audio clip for a set duration
    public void ShowTextBubble()
    {
        //Enable the text bubble
        textBubble.enabled = true;

        //Set the timer length
        bubbleTimer = Time.time + audioClip.length + 3;
    }

    //Update the timer and disable the text bubble once the timer ends
    void Update()
    {
        if (textBubble.enabled && (Time.time >= bubbleTimer))
        {
            textBubble.enabled = false;
        }
    }
}
