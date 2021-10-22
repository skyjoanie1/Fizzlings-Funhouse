using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    //Controls the speed at which the notes move
    public float beatTempo;
    //Trying to hook up the cord, which allows the player to know when to click on the note
    public GameObject cord;
    

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

        StartCoroutine(destroyNote());
        


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(Input.GetMouseButton(0))
        {
            Destroy(this.gameObject);
            beatTempo = beatTempo++ / 60f;
        }
    }
    


    //Destroys the note at a point in time, so we don't have a lot of notes in the scene
    IEnumerator destroyNote()
    {

        yield return new WaitForSeconds(7f);
        Destroy(this.gameObject);

    }

}
