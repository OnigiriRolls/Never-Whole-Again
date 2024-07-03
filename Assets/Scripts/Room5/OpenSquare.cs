using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSquare : MonoBehaviour
{
    public GameObject trigger;
    public GameObject toOpen;

    private void OnMouseDown()
    {
        Debug.Log("apasat");
        if (trigger.GetComponent<InSquare>().stateBoy == true)
        {
            toOpen.SetActive(true);
        }
    }
}
