using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnfood : MonoBehaviour
{
    public GameObject myPrefab;
    public Transform spawnPoint;
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Pig"))
        { 

            Instantiate(myPrefab, spawnPoint.position, Quaternion.identity);
           
        }
           

    }

}
