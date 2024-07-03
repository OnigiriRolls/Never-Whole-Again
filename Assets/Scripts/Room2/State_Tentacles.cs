using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Tentacles : MonoBehaviour
{
    
    void Start()
    {
        this.GetComponent<Animator>().enabled = false;
        if(GlobalManager.Instance.R2_Room4_Open==true)
        {
            this.gameObject.SetActive(false);
        }
    }

   
    
}
