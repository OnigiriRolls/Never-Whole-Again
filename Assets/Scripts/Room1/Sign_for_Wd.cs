using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign_for_Wd : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player1") && GlobalManager.Instance.torch_taken == false)
        {
            GlobalManager.Instance.R1_wd_trigger = true;

        }

    }
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1") && GlobalManager.Instance.R1_wd_trigger == false)
        {
            GlobalManager.Instance.R1_wd_trigger = true;

        }

    }

    private void OnTriggerExit2D(Collider2D player)
    {
      
            GlobalManager.Instance.R1_wd_trigger =false;
        
    }
}
