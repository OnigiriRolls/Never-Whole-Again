using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_panel : MonoBehaviour
{
    public GameObject toOpen;
    private void Start()
    {
        toOpen.SetActive(true);
    }
}
