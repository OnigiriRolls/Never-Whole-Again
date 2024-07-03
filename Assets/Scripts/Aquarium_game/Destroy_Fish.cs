using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Fish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        
        if(enemy.CompareTag("fish")|| enemy.CompareTag("bullet"))
        Destroy(enemy.gameObject);
    }
}
