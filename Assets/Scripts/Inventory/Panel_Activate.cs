using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_Activate : MonoBehaviour
{
    GameObject ob;
    private void Start()
    {  GlobalManager.Instance.code_active = true;
        
    }
    public void Activate()
    {
        ob = GameObject.Find("Canvas_paper").transform.Find("Panel").gameObject;
        Debug.Log(ob.name);
        ob.gameObject.SetActive(true);
    }
}
