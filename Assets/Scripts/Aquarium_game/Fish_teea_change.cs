using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_teea_change : MonoBehaviour
{
    public GameObject toChange;

    private void OnEnable()
    {
        if(toChange!=null && toChange.activeSelf==true)
        toChange.SetActive(false);
    }
    private void OnDisable()
    {
        if (toChange != null && toChange.activeSelf == false && GlobalManager.Instance.end_on==false)
            toChange.SetActive(true);
    }
}
