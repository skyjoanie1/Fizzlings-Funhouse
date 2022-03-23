using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepHealthSystem : MonoBehaviour
{
    public GameObject[] sheepHearts;
    public int sLife;
    // Start is called before the first frame update
    void Start()
    {
        sLife = sheepHearts.Length;
    }

    // Update is called once per frame

    public void SheepTakeDamage(int d)
    {
        if (sLife >= 1)
        {
            //subtract a heart
            sLife -= d;
            //destroy a heart
            Destroy(sheepHearts[sLife].gameObject);
        }
    }
}
