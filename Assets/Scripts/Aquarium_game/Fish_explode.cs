using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish_explode : MonoBehaviour
{
    public GameObject panel;
    public float dmg;
    public Image[] hearts;
    public float health;
    int i;

    private void Start()
    {
        health = 120;
        i = hearts.Length-1;
        
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if(enemy.CompareTag("fish")|| enemy.CompareTag("bullet"))
        {
            health=health - dmg;
            if(i>=0)
            hearts[i].gameObject.SetActive(false);
            i--;
            if(health==0)
            {
                Time.timeScale = 0f;
                panel.SetActive(true);
            }
            enemy.GetComponent<SpriteRenderer>().enabled = false;
            enemy.transform.GetChild(0).gameObject.SetActive(true);

        }
        if(enemy.CompareTag("fish1"))
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
        }
      
    }
}
