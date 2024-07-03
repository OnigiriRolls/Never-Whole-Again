using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class move_Mat : MonoBehaviour
{
    public GameObject mat;
    

    bool state;


  
    private void Start()
    {
        if(GlobalManager.Instance.keyState==true)
        mat.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        state = true;
      
    }

    private void OnMouseDown()
    {if (state == true)
        {       

            mat.SetActive(false);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        state = false;
      
    }

  
    
}
