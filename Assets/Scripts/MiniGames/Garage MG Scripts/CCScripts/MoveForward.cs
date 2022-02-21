using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour 
{
	public float speed;
	
	// Move forward every frame
	void Update ()
	{
		transform.Translate (0, Time.deltaTime * speed, 0);
	}
}
