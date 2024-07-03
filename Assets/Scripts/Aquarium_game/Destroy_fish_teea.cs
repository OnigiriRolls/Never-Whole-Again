using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_fish_teea : MonoBehaviour
{
    public GameObject fish;

    private void OnTriggerEnter2D(Collider2D enemy)
    {

        if (enemy.CompareTag("fish") || enemy.CompareTag("bullet"))
        {
            Destroy(enemy.gameObject);
            gameObject.SetActive(false);
            fish.SetActive(false);
        }
    }
}
