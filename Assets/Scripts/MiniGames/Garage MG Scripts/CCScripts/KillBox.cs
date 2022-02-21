using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Coins")
        {

            Destroy(col.gameObject);

        }

    }

}
