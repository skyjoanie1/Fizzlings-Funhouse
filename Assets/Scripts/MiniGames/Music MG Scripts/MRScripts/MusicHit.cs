using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHit : MonoBehaviour
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
                gameObject.SetActive(false);
                Destroy(gameObject);
                NotesManager.instance.NoteHit();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            if (gameObject.activeSelf)
            {
                canBePressed = false;
                NotesManager.instance.NoteMiss();
            }
           // canBePressed = false;
            Destroy(gameObject);
            
        }
    }


}
