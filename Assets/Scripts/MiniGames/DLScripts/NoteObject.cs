using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    public KeyCode keyToPress;

    private GameObject DLGM;

    private DLGameManager DL;


    // Start is called before the first frame update
    void Start()
    {
        DLGM = GameObject.FindGameObjectWithTag("DLGM");
        DL = DLGM.GetComponent<DLGameManager>();

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Mathf.Abs(transform.position.y));

        if (Input.GetKeyDown(keyToPress))
        {

            if (canBePressed)
            {

                /*
                if(Mathf.Abs(transform.position.y) > 0.2)
                {

                    Debug.Log("Hit");
                    GameManager.Instance.NormalHit();

                } else if (Mathf.Abs(transform.position.y) > -0.2f)
                {

                    Debug.Log("Good");
                    GameManager.Instance.GoodHit();

                } else
                {

                    Debug.Log("Perfect");
                    GameManager.Instance.PerfectHit();

                }

    */


                DL.NoteHit();

                // If note is hit this gameObject will be no longer be active
                gameObject.SetActive(false);

                // If canBePressed is true and the correct corresponding button is pressed the arrow object will be destroyed.
                Destroy(this.gameObject);



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


        if (gameObject.activeSelf)
        {
            if (other.tag == "Activator")
            {

                // When the arrow exits the button boxes, canBePressed becomes false
                canBePressed = false;

                // When the note exits the Activator, NoteMissed function is called
                DL.NoteMissed();

                // If note is missed DestroyNote will be called
                StartCoroutine(DestroyNote());

            }
        }

    }

    
    IEnumerator DestroyNote()
    {
        // Wait 1 second and then destroy this gameObject
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);

    }

}
