using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_children : MonoBehaviour
{
    private void OnEnable()
    {
        if(transform.childCount>0)
        {
            for (int i = 0; i < transform.childCount; i++)
                transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
