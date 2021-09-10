using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTutor : MonoBehaviour
{
    //Reference to the cord game object
    public GameObject cord;

    //When the player interacts with the notes, check if it is the tutorial or not
    //If it is, set tutorialMove to true, else set realMove to true
    public void Interaction()
    {
        if (cord.GetComponent<NoteType>().tutorialMove == false)
        {
            cord.GetComponent<NoteType>().tutorialMove = true;
        }
        else if (cord.GetComponent<NoteType>().realMove == false)
        {
            cord.GetComponent<NoteType>().realMove = true;
            Destroy(this.gameObject);
        }
    }
}
