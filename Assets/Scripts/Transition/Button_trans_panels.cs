using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button_trans_panels : MonoBehaviour
{
    public GameObject toActivate;
    public GameObject toDeactivate;

   public void next()
    {
        toActivate.SetActive(true);
        toDeactivate.SetActive(false);
    }
}
