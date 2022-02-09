using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepLifeTime : MonoBehaviour
{
    //how long the bubble will last
    public float lifeTime;
    //calling healthsystem script
    public SheepHealthSystem sHearts;

    public bool fed;

    private void Start()
    {
        sHearts = GameObject.Find("Sheep 1").GetComponent<SheepHealthSystem>();
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

                sHearts.SheepTakeDamage(1);
            }
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sheep")
        {
            fed = true;
        }
        else
        {
            sHearts.SheepTakeDamage(1);
            fed = true;
        }
    }
}
