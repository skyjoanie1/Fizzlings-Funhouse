using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBooks : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] prefabs;

    const int gapIndex = 0;

    void Start()
    {
        List<int> usedIndices = new List<int>();
        for (int i = 0; i < spawnPoints.Length; i++) usedIndices.Add(UnityEngine.Random.Range(0, prefabs.Length));

        if (!usedIndices.Contains(gapIndex)) usedIndices[UnityEngine.Random.Range(0, usedIndices.Count)] = gapIndex;

        for (int i = 0; i < spawnPoints.Length; i++) Instantiate(prefabs[usedIndices[i]], spawnPoints[i].position, Quaternion.identity);

    }
}
