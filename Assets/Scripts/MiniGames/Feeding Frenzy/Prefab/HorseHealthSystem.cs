using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseHealthSystem : MonoBehaviour
{
    public GameObject[] horseHearts;
    public int hLife;
    // Start is called before the first frame update
    void Start()
    {
        hLife = horseHearts.Length;
    }

    // Update is called once per frame

    public void HorseTakeDamage(int d)
    {
        if (hLife >= 1)
        {
            //subtract a heart
            hLife -= d;
            //destroy a heart
            Destroy(horseHearts[hLife].gameObject);
        }
    }
}
