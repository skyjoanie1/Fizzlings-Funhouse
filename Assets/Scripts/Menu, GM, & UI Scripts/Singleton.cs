using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    
    //Create variable to hold the instance of the singleton
    private static T instance;

    //Get the instance of singleton
    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    //Check if a singleton exists
    public static bool IsInitialized
    {
        get
        {
            return instance != null;
        }
    }

    //On Awake, call IsInitiallized and destroy any extra singletons if there are any
    //If there aren't any other singletons, prevent it from being destroyed when loading new scenes
    protected virtual void Awake()
    {
        if (IsInitialized)
        {
            Debug.Log("[Singleton] Already Exists");
            Destroy(this.gameObject);
        }
        else
        {
            instance = (T)this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    //If or when a singleton is destroyed, set the instance to null
    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}