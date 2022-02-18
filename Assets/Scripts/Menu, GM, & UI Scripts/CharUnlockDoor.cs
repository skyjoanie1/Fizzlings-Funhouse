using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharUnlockDoor : MonoBehaviour
{
    //Create a variable to hold the door object
    public GameObject door;

    //Destroy Rizzy sprite and allow interaction with the room's door
    public void Interaction()
    {
        door.SetActive(true);
        Destroy(this.gameObject);
    }
}
