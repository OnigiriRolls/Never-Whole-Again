using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_full : MonoBehaviour
{
     GlobalManager gl;

    void OnEnable()
    {
        gl = GameObject.Find("GlobalManager").GetComponent<GlobalManager>();
        if(transform.childCount>0)
        if(gl.spawn_empty==true && gl.spawn_full==true &&gl.Recipient_full==false)
            transform.GetChild(1).gameObject.SetActive(true);
    }


}
