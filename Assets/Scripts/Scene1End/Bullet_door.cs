using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="bullet")
        {
            
            collision.GetComponent<SpriteRenderer>().enabled = false;
            collision.transform.GetChild(0).gameObject.SetActive(true);
           
        }
    }

}
