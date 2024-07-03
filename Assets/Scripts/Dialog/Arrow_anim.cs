using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_anim : MonoBehaviour
{
    Animator anim;
    public string den;
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool(den, true);
    }
    
}
