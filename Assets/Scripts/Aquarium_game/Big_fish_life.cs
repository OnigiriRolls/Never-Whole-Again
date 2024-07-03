using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_fish_life : MonoBehaviour
{
    
    public GameObject panel;

    

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        if (collision.CompareTag("Player1"))
        {
            
            Time.timeScale = 0f;
            panel.SetActive(true);
        }
        else if (collision.CompareTag("wall"))
        {
            gameObject.SetActive(false);

        }
        else if (collision.gameObject.name == "Teea_Mermaid")
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
        }

    }
}
