using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_Operator : MonoBehaviour
{
 

    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.CompareTag("Player1"))
        GlobalManager.Instance.R2_wd_trigger = true;
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1"))
        {
            GlobalManager.Instance.R2_wd_trigger = false;
           
        }
       
    }
    private void Update()
    {
        if (GlobalManager.Instance.Recipient_empty == true)
        { 
            this.GetComponent<Trigger_Operator>().enabled = false;
        }
    }
    private void OnTriggerStay2D(Collider2D player)
    {
        if (player.CompareTag("Player1") && GlobalManager.Instance.R2_wd_trigger==false)
            GlobalManager.Instance.R2_wd_trigger = true;
    }
   
}
