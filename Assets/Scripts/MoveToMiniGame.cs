using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMiniGame : MonoBehaviour
{
    //Variable to hold the scene name
    public string scene;

    //Load new scene and close other scenes to save memory
    public void Interaction()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
