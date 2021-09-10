using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast2D : MonoBehaviour
{
    //When clicking left mouse button, create a raycast to check for collider in following rooms
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Raycast to move
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            if (rayHit.collider)
            {
                //Send a message to indicate that this is an interaction
                Debug.Log(rayHit.collider.gameObject.name);
                rayHit.collider.gameObject.SendMessage("Interaction", null, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
