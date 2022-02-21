using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleBullet : MonoBehaviour
{
    //Variable to gain access the the turtle's transform
    public Transform tf;

    //Variable to handle the turtle's movement speed
    public float turtleSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Always move forward (a.k.a. to the left)
        tf.position -= tf.right * turtleSpeed * Time.deltaTime;

        if (tf.position.x <= -16)
        {
            GameManager.Instance.turtleRescuePoints++;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.tag == "Seagull")
        {
            Destroy(this.gameObject);
        }
    }
}
