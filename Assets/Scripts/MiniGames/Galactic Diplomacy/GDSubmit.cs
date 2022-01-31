using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDSubmit : MonoBehaviour
{
    //Reference to the "game" Game Object
    public GameObject game;

    //Check if the player is clicking on submit arrow
    public void Interaction()
    {
        game.GetComponent<GDGame>().answer = game.GetComponent<GDGame>().selected;
    }
}
