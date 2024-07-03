using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R5_Open1 : MonoBehaviour
{
    public GameObject trigger;
    public GameObject toOpen;

    private void OnMouseDown()
    {
        if (trigger.GetComponent<Sign1>().playerInRange == true)
        {
            toOpen.SetActive(true);
        }
    }
}
