using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;

    public bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        // Tells how fast the arrows should move
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                // If any button has been pressed game will start
                hasStarted = true;
            }
            
        } else
        {
            // Makes arrows move
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);

        }


    }
}
