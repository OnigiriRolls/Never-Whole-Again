using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_fish_life2 : MonoBehaviour
{
    public GameObject panel;
     int health;
    public int maxHealth;
    public int dmg;
    public Animator anim;
    public GameObject effect;
   

    void OnEnable()
    {
        health = maxHealth; 
    }

    void Update()
    {
        if (health == 0)
        {
            transform.parent.gameObject.SetActive(false);
            GlobalManager.Instance.bigFish = true;
            effect.transform.position = transform.parent.transform.position;
            effect.SetActive(true);
            
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("bullet"))
        {   
             health =  health - dmg;
            collision.tag = "fish";
            collision.GetComponent<SpriteRenderer>().enabled = false;
            collision.transform.GetChild(0).gameObject.SetActive(true);
            
            if(health>0)
            anim.SetTrigger("fade");
          
           
        }
        else if (collision.CompareTag("Player1"))
        {
           
            Time.timeScale = 0f;
            panel.SetActive(true);
        }
        else if (collision.CompareTag("wall"))
        {
            transform.parent.gameObject.SetActive(false);

        }
        else if (collision.gameObject.name == "Teea_Mermaid")
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
        }
 
    }

}
