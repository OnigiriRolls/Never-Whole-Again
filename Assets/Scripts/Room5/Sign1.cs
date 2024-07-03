using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign1 : MonoBehaviour
{
    public GameObject obj;
    public bool playerInRange;


    private void OnTriggerEnter2D(Collider2D player)
    {
        obj.GetComponent<PolygonCollider2D>().enabled = false;
        obj.GetComponent<PolygonCollider2D>().enabled = true;
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
