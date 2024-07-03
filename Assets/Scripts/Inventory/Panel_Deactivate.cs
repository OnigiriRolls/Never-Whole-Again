using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Deactivate : MonoBehaviour
{
    public void Deactivate()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
