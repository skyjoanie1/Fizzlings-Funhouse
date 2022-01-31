using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerToGM : MonoBehaviour
{
    //Create an instance of the player in the Game Manager
    void Start()
    {
        GameManager.Instance.player = this.gameObject;
    }
}
