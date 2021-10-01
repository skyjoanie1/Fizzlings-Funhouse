using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNoteExperiment : MonoBehaviour
{
    public GameObject note;

    private Transform[] spawnPoints;

    public float maxTime = 10;

    public float minTime = 1;

    private float time;

    private float spawnTime;

    private void Awake()
    {
        List<Transform> spawningPointsAsList = new List<Transform>();

        foreach(Transform child in transform)
        {
            spawningPointsAsList.Add(child);
        }
        spawnPoints = spawningPointsAsList.ToArray();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
