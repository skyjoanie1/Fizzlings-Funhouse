using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRLizaMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.RightArrow)){

            rb.MovePosition(rb.position + Vector2.right);

        } else if(Input.GetKeyDown(KeyCode.LeftArrow)){

            rb.MovePosition(rb.position + Vector2.left);

        } else if(Input.GetKeyDown(KeyCode.UpArrow)){

            rb.MovePosition(rb.position + Vector2.up);

        } else if(Input.GetKeyDown(KeyCode.DownArrow)){

            rb.MovePosition(rb.position + Vector2.down);

        }
        
    }
}
