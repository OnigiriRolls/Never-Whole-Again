using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_wd : MonoBehaviour
{

    public GameObject wd1;
    public GameObject toActivate;
    public GameObject toFuse;
    
    void Update()
    {
        if (this.transform.childCount > 0)
        {
            if (this.transform.GetChild(0).name.Equals("Fuse") && this.transform.childCount == 1)
            {
                toActivate.SetActive(true);
                toFuse.SetActive(true);
                wd1.SetActive(false);
                gameObject.SetActive(false);
            }
        }
        else 
        {
            toActivate.SetActive(true);
            toFuse.SetActive(false);
            wd1.SetActive(false);
        }
    }
}
