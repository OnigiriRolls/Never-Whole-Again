using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Op_Machine : MonoBehaviour
{
    
    void Start()
    {
        if(GlobalManager.Instance.R2_Room4_Open==true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

   
}
