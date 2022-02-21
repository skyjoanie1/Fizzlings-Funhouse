using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Variable to access the player's rigidbody2d
    private Rigidbody2D rb2d;

    //Vector to reference player movement
    Vector2 movement;

    //Variable to control the player's movement speed
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set Player movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");        
    }

    //Fixed Update is better for handling things you want called repeatedly, but not every frame
    void FixedUpdate()
    {
        //Move the player
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
