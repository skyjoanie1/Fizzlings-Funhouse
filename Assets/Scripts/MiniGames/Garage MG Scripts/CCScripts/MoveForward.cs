using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour 
{
	public float speed;

	private void Start()
	{
		StartCoroutine("KillTime");
	}

	// Move forward every frame
	void Update ()
	{
		transform.Translate (0, Time.deltaTime * speed, 0);
	}

	IEnumerator KillTime()
	{

		yield return new WaitForSeconds(15f);
		Destroy(this.gameObject);
	}

}
