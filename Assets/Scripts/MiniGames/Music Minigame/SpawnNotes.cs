using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNotes : MonoBehaviour
{
    //Note Prefab variables
    private GameObject notePrefab;
    private GameObject notePrefab1;
    private GameObject notePrefab2;
    private GameObject notePrefab3;
    private GameObject notePrefab4;

    public GameObject[] notes = new GameObject[] { };

    public GameObject[] noteSpawners = new GameObject[] { };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.numNotes < 2)
        {
            Debug.Log("Spawned a note");
            SpawnNote();
        }
    }

    //Function to spawn notes
    public void SpawnNote()
    {
        int randomSpawnPoint = Random.Range(0, noteSpawners.Length);

        int randomNote = Random.Range(0, notes.Length);

        Instantiate(notes[randomNote], noteSpawners[randomSpawnPoint].transform.position, transform.rotation);

        GameManager.Instance.numNotes++;

    }
}
