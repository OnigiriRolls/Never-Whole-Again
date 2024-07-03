using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_activate1 : MonoBehaviour
{
    GameObject ob;
    private void Start()
    {
        GlobalManager.Instance.code_active = true;
        ob = GameObject.Find("Paper_canvas").transform.GetChild(0).gameObject;
    }
    public void Activate()
    {
        ob.SetActive(true);
    }
}
