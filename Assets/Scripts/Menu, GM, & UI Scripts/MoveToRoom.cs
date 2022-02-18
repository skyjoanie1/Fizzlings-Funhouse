using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRoom : MonoBehaviour
{
    //Variable to hold the value of the next scene
    public int roomToGo;

    //Set the current room value equal to the next scenes value
    public void Interaction()
    {
        GameManager.Instance.currRoom = roomToGo;
    }
}
