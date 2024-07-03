using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_trigger : MonoBehaviour
{
    public GameObject obj;
    private void Update()
    {
        if (obj.activeSelf == true)
            this.gameObject.SetActive(false);
    }
}
