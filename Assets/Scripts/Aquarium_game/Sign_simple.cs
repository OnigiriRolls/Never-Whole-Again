using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign_simple : MonoBehaviour
{
   
    public bool playerInRange;


    private void OnTriggerEnter2D(Collider2D player)
    {
       
        if (player.CompareTag("Player1"))
        {
            playerInRange = true;

        }
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1"))
            playerInRange = false;
    }
}
