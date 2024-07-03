using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R5_Open : MonoBehaviour
{
    public GameObject trigger;
    public GameObject toOpen;

    private void OnMouseDown()
    {  
        if (trigger.GetComponent<Sign>().playerInRange == true)
        {
            toOpen.SetActive(true);
        }
    }
}
