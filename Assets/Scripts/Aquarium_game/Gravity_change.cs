using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_change : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player1"))
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1"))
            player.GetComponent<Rigidbody2D>().gravityScale = 2;
    }

}
