using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.CompareTag("Player1"))
        {
            player.GetComponent<Jhin_Health>().air = 11;
            player.GetComponent<Jhin_Health>().StopAllCoroutines();
    
        }
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1"))
        {
           
            player.GetComponent<Jhin_Health>().StartCoroutine("AirPass");
        }
    }

    
}
