using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_panel : MonoBehaviour
{
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(true);
    }

   
}
