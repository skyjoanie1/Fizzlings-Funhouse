using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNoteExperiment : MonoBehaviour
{
    public GameObject note;


    public float maxTime = 10;

    public float minTime = 1;

    private float time;

    private float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
    }


    void SpawnObject()
    {
        time = 0;
        Instantiate(note, transform.position, note.transform.rotation);
    }
}
