using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Open_Minigame : MonoBehaviour
{
    public GameObject trigger;
    public GameObject toOpen;
    public Image img;
    public GameObject boy;


    private void OnMouseDown()
    {
       
        if (trigger.GetComponent<Sign1>().playerInRange == true )
        {
            
           
            if (boy.GetComponent<Inventory>().isfull[3] == true)
            { img.gameObject.SetActive(true);
                
            }
            else
                toOpen.SetActive(true);
        }
    }
    private void Update()
    {
        
        if (trigger.GetComponent<Sign1>().playerInRange == false && img.gameObject.activeSelf == true)
            img.gameObject.SetActive(false);
    }
}
