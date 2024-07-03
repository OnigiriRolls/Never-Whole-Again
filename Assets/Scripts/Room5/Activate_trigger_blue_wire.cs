using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_trigger_blue_wire : MonoBehaviour
{
    public GameObject wire;
    public GameObject ob;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (wire != null)
        {
            if (ob.activeSelf == true)
            {
                wire.GetComponent<BoxCollider2D>().enabled = false;
                wire.GetComponent<BoxCollider2D>().enabled = true;

            }
        }
    }

}
