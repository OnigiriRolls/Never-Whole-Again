using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public string s;
    public Animator anim;
    void Start()
    {
        anim.SetTrigger(s);
        gameObject.SetActive(false);
        if (s == "exit")
            GlobalManager.Instance.exit = true;
    }

    
}
