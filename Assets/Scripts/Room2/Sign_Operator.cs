using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign_Operator : MonoBehaviour
{

   
    //bool state;
 
    private void OnTriggerEnter2D(Collider2D player)
    {
        // state = true;
        GlobalManager.Instance.R2_machine_trigger = true;
     

    }
 
    private void OnTriggerExit2D(Collider2D collision)
    {
        // state= false;
        GlobalManager.Instance.R2_machine_trigger = false;
     
       
    }
   
}
