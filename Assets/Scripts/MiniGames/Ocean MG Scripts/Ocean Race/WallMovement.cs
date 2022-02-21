using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - 0.3f, transform.position.y), 0.1f);
    }
}
