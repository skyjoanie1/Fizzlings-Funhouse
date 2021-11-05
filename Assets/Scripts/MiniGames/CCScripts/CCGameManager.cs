using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCGameManager : MonoBehaviour
{

    public GameObject StartScreen;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {

            StartScreen.SetActive(false);
            Time.timeScale = 1;

        }
        
    }
}
