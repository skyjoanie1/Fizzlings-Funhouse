using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BREnemyMovement : MonoBehaviour
{

    private bool MoveLeft;
    private bool MoveRight;

    // Start is called before the first frame update
    void Start()
    {

        if (transform.position.x > 0)
        {
            MoveToLeft();
            Debug.Log("Moving Left");
        }
        else if (transform.position.x < 0)
        {
            MoveToRight();
            Debug.Log("Moving Right");
        }


    }

    // Update is called once per frame
    void Update()
    {

        if(MoveLeft == true)
        {
            transform.position = transform.position - new Vector3(2, 0, 0) * Time.deltaTime;

        }
        else if (MoveRight == true)
        {
            transform.position = transform.position - new Vector3(-2, 0, 0) * Time.deltaTime;

        }

        if (transform.position.x > 8)
        {
            Destroy(this.gameObject);
        }
        else if (transform.position.x < -8)
        {
            Destroy(this.gameObject);
        }

    }


    public void MoveToLeft()
    {

        //transform.position = transform.position - new Vector3(2, 0, 0) * Time.deltaTime;
        MoveLeft = true;

    }

    public void MoveToRight()
    {

       // transform.position = transform.position - new Vector3(-2, 0, 0) * Time.deltaTime;
        MoveRight = true;

    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {

            Destroy(col.gameObject);

        }

    }

}
