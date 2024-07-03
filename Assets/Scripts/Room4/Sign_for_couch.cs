using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign_for_couch : MonoBehaviour
{
    
    


    private void OnTriggerEnter2D(Collider2D player)
    {
       
        if (player.CompareTag("Player1") && this.transform.childCount>0)
        { this.GetComponent<ItemState>().active = true;
          
        }
    }
  


    private void OnTriggerExit2D(Collider2D player)
    {
      
        if (player.CompareTag("Player1") )
        {
            
            this.GetComponent<ItemState>().active = false;
        }
    }
}
