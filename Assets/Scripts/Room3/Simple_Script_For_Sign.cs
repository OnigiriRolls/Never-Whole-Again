using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Simple_Script_For_Sign : MonoBehaviour
{
  
    

    private void OnTriggerEnter2D(Collider2D player)
    {
        
       
        if(player.CompareTag("Player1"))
        {
             GlobalManager.Instance.R3_fill_trigger = true;
        }
    }
  


    private void OnTriggerExit2D(Collider2D player)
    {
       
        if (player.CompareTag("Player1") )
        {
             GlobalManager.Instance.R3_fill_trigger = false;
        }
    }
}
