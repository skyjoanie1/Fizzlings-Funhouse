using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Singleton for GameManager
public class RMSSingleton<T> : MonoBehaviour where T : RMSSingleton<T>
{
	private static T instance;

	
	public static T Instance
	{
		get
		{
			return instance;
		}

	}

	public bool IsInitialized
	{
		get
		{
			return instance != null;
		}

	}

	// Stops more than one singleton being created.
	protected virtual void Awake()
	{
		//Checks for an instance of the singleton
		if (IsInitialized)
		{
			Debug.LogError("[Singleton] Tried to create a second instance of a Singleton Class");
			GameObject.Destroy(gameObject);
		}
		else
		{
		
			instance = (T)this;
			DontDestroyOnLoad(gameObject);
		}
		
	}

	protected virtual void OnDestroy()
	{
		instance = null;

	}





}
