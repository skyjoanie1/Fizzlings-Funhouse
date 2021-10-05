using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(keyToPress))
        {

            if (canBePressed)
            {
                // If canBePressed is true and the correct corresponding button is pressed the arrow object will be hidden
                gameObject.SetActive(false);
                DLManager.Instance.NoteHit();

            }

        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Activator")
        {
            // When arrows enter the button boxes, canBePressed becomes true
            canBePressed = true;

        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Activator")
        {
            // When the arrow exits the button boxes, canBePressed becomes false
            canBePressed = false;
            DLManager.Instance.NoteMissed();

        }

    }

}
