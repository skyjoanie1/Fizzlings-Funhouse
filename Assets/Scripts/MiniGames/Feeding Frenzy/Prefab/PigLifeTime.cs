using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigLifeTime : MonoBehaviour
{
    //how long the bubble will last
    public float lifeTime;
    //calling healthsystem script
    public PigHealthSystem phearts;

    public bool fed;
    

    private void Start()
    {

        phearts = GameObject.Find("Pig 1").GetComponent<PigHealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the lifetime is less then zero do this
        if (lifeTime > 0)
        {
            //subtract the time you give it and count down
            lifeTime -= Time.deltaTime;
            //if it reaches zero or is greater then zero do this
            if (lifeTime <= 0)
            {
                //call destory function
                Destroyed();
            }
        }
    }
    //destory the gameobject
    void Destroyed()
    {
        {
            if (fed == false)
            {
                //lose a heart
                
                phearts.PigTakeDamage(1);
            }
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Pig")
        {
            fed = true;
        }
        else
        {
            phearts.PigTakeDamage(1);
            fed = true;
        }
    }


}
