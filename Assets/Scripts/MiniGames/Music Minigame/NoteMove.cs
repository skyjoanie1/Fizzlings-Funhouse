using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    //Create a variable to check if the tutorial is active or not
    public bool tutorial = false;

    //Bar to show when the player should click on the note
    public GameObject cord;

    // Update is called once per frame
    void Update()
    {
        
    }

    //If the player left clicks or tutorial equals true, destroy the clicked game object
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetMouseButton(0) || tutorial == true)
        {
            Destroy(this.gameObject);
        }
    }

    public void Movement()
    {
        //If the tutorial is active, move the tutorial note by setting tutorialMove to true
        //and adjust its transformation accordingly
        if (tutorial == true)
        {
            if (cord.GetComponent<NoteType>().tutorialMove == true)
            {
                transform.position += transform.right * Time.deltaTime;
            }
        }
        else
        {
            //Else, activate the gameplay movement
            if (cord.GetComponent<NoteType>().realMove == true)
            {
                Debug.Log("Note moving");
                transform.position += transform.right * Time.deltaTime;
            }
        }
    }
}
