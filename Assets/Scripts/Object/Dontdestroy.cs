using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    public bool[] full;
    private void Awake()
    {
        DontDestroyOnLoad(this.transform);
    }
}
