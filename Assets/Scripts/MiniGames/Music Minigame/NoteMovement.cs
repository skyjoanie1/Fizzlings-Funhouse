using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{

    public float beatTempo;

    

    // Start is called before the first frame update
    void Start()
    {
        // Tells how fast the arrows should move
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {

        
        
            // Makes arrows move
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);

        


    }
}
