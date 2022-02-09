using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseLifeTime : MonoBehaviour
{
    //how long the bubble will last
    public float lifeTime;
    //calling healthsystem script
    public HorseHealthSystem hHearts;

    public bool fed;

    private void Start()
    {
        hHearts = GameObject.Find("Horse 1").GetComponent<HorseHealthSystem>();

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

                //lose a heart
                //hearts.TakeDamage(1);
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

                hHearts.HorseTakeDamage(1);
            }
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Horse")
        {
            fed = true;
        }
        else
        {
            hHearts.HorseTakeDamage(1);
            fed = true;
        }
    }



}
