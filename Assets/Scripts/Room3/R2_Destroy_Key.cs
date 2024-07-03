using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2_Destroy_Key : MonoBehaviour
{
    
    void Start()
    {
        if (GlobalManager.Instance.keyState == true)
            Destroy(this.gameObject);
    }

    
}
