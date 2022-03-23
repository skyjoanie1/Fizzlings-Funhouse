using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MADGameManager : MonoBehaviour
{

    public List <GameObject> Stories;

    // Start is called before the first frame update
    void Start()
    {

        EnableStory();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableStory()
    {

        int RandomNum;
        RandomNum = Random.Range(0, Stories.Count);
        Stories[RandomNum].SetActive(true);

    }

}
