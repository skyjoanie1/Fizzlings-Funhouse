using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnfood : MonoBehaviour
{
    //gets the prefab of the object
    public GameObject myPrefab;
    //will spawn the food in
    public GameObject spawnPoint;



//if you collide with the trigger do something
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Pig")
        {

            //Debug.Log("Feed");

            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);

        }

        if (collision.gameObject.tag == "Horse")
        {

            //Debug.Log("Feed");

            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);

        }

        if (collision.gameObject.tag == "Sheep")
        {

            //Debug.Log("Feed");

            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);

        }

        /*

        //if you collide with the trigger and the tag matches pig then spawn new food item 
        if (collision.transform.CompareTag("Pig"))
        {
            spawnPoint = GameObject.Find("SpawnWheat").transform;
            Instantiate(myPrefab, spawnPoint.position, Quaternion.identity);
           
        }

        if (collision.transform.CompareTag("Horse"))
        {
  
            spawnPoint = GameObject.Find("SpawnApple").transform;
            Instantiate(myPrefab, spawnPoint.position, Quaternion.identity);

        }

        if (collision.transform.CompareTag("Sheep"))
        {
            spawnPoint = GameObject.Find("SpawnCarrot").transform;
            Instantiate(myPrefab, spawnPoint.position, Quaternion.identity);

        }

        */

    }

}
