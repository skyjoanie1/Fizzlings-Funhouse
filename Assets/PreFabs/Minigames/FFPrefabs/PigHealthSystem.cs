using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigHealthSystem : MonoBehaviour
{
    public GameObject[] pighearts;
    public int plife;
    // Start is called before the first frame update
    void Start()
    {
        plife = pighearts.Length;
    }

    // Update is called once per frame

    public void PigTakeDamage(int d)
    {
        if (plife >= 1)
        {
            //subtract a heart
            plife -= d;
            //destroy a heart
            Destroy(pighearts[plife].gameObject);
        }
    }
}
