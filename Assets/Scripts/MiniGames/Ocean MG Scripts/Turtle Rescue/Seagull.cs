using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagull : MonoBehaviour
{
    //Variable to access to the seagull's transform
    public Transform tf;

    //Variable to handle the seagull speed
    public float seagullSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Always move down
        tf.position -= tf.up * seagullSpeed * Time.deltaTime;

        if (tf.position.y <= -13)
        {


            Destroy(this.gameObject);            
        }
    }

    public void OnTriggerEnter2D (Collider2D otherObject)
    {
        if (otherObject.tag == "Turtle")
        {
            Destroy(otherObject.gameObject);
        }
    }
}
