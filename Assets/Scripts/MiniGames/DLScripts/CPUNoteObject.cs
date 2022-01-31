using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUNoteObject : MonoBehaviour
{
    public bool canBePressed;

    public int noteNum;

    private GameObject DLGM;

    private DLGameManager DL;


    // Start is called before the first frame update
    void Start()
    {

        // Generates a random number for noteNum
        noteNum = Random.Range(1, 3);
        DLGM = GameObject.FindGameObjectWithTag("DLGM");
        DL = DLGM.GetComponent<DLGameManager>();

    }

    // Update is called once per frame
    void Update()
    {

        if (canBePressed)
        {
            if (noteNum == DL.cpuNum)
            {
                // If the noteNum is equal to the random number generated for the cpuNum and canBePressed is true then call cpuHit
                CPUHit();

            }

        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "CPUActivator")
        {
            // When arrows enter the button boxes, canBePressed becomes true
            canBePressed = true;

        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {


        if (gameObject.activeSelf)
        {
            if (other.tag == "CPUActivator")
            {

                // When the arrow exits the button boxes, canBePressed becomes false
                canBePressed = false;

                // When the note exits the Activator, NoteMissed function is called
                DL.CPUNoteMissed();

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

    public void CPUHit()
    {



        DL.CPUNoteHit();




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
        // If the note is hit by the CPU, the cpuNum will reset based on this Random.Range
        DL.cpuNum = Random.Range(1, 3);

        // If note is hit this gameObject will be no longer be active
        gameObject.SetActive(false);

        // If canBePressed is true and CPU has hit the note, the arrow object will be destroyed.
        Destroy(this.gameObject);


    }
}
