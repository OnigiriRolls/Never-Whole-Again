using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_Open : MonoBehaviour
{
    public GameObject trigger;
    public GameObject toOpen;

    private void OnMouseDown()
    {
        if (trigger.GetComponent<Sign>().playerInRange == true && GlobalManager.Instance.R5_lock==true)
            toOpen.SetActive(true);
    }
}
