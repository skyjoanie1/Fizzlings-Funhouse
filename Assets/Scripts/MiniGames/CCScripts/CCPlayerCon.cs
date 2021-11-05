using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CCPlayerCon : MonoBehaviour
{

    public int playerHealth = 100;

    public int playerPoints;

    public Text healthText;
    public Text PointsText;

    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        rb = GetComponent<Rigidbody2D>();

        PointsText.text = "Points: " + playerPoints;
        healthText.text = "Health: " + playerHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        rb.velocity = movement * speed;

    }

    public void OnTriggerEnter2D (Collider2D col)
    {

        if (col.gameObject.tag == "Enemy")
        {

            playerHealth = playerHealth - 10;
            healthText.text = "Health: " + playerHealth;
            Destroy(col.gameObject);

        }

        if (col.gameObject.tag == "Coins")
        {

            playerPoints = playerPoints + 10;
            PointsText.text = "Points: " + playerPoints;
            Destroy(col.gameObject);

        }

    }

}
