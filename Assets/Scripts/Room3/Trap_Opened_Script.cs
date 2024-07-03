using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap_Opened_Script : MonoBehaviour
{
    public GameObject ob;
    bool state;
    public GameObject mat;
    public bool playerInRange;

    private void Start()
    {
        if(GlobalManager.Instance.keyState==true)
        ob.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {if(collision.CompareTag("Player1"))
        playerInRange = true;
    }

    private void OnMouseDown()
    {
       
        if (mat.activeSelf == false && playerInRange==true)
        {
                 
            ob.SetActive(true);
           
        }
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
            playerInRange = false;

    }
}
