using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Activate : MonoBehaviour
{
    public GameObject wd;
  
    
    public GameObject open;
    

   

    private void OnMouseDown()
    {
        if(open.GetComponent<Sign>().playerInRange==true)
        {
               
            wd.gameObject.SetActive(true);
            this.GetComponent<BoxCollider2D>().enabled = false;
                  
        }
    }
   
   
}
