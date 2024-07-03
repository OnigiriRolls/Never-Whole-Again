using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransItems: MonoBehaviour
{
    public static TransItems Instance;
 

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);

            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);         
        }
        
    }
}
