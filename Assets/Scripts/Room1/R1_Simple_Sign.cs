using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class R1_Simple_Sign : MonoBehaviour
{
    public bool state;
   
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player1"))
        {
            state = true;     
        }

    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1") )
        {
            state = false;
        }
       
    }
}
