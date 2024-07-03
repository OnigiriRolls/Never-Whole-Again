using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_destroy_fish : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player1")
        {
            gameObject.SetActive(false);
            panel.SetActive(true);
        }
    }
}
