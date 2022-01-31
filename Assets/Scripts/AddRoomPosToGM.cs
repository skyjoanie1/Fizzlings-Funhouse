using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoomPosToGM : MonoBehaviour
{
    //Create a variable to handle each room's associated number
    public int roomNum;

    //Grab the number of the room and add it to the array
    //Room number is set in the inspector
    void Start()
    {
        GameManager.Instance.rooms[roomNum - 1] = this.gameObject;
    }
}