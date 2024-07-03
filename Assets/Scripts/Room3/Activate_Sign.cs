using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Activate_Sign : MonoBehaviour
{

    
    public GameObject mat;
    
    public Canvas lookCloser;
   public GameObject trigmat;

 

   

    private void OnMouseDown()
    {
        if (mat.activeSelf == false && trigmat.GetComponent<Trap_Opened_Script>().playerInRange==true)
        {  
                lookCloser.gameObject.SetActive(true);          
        }
    }

   


}
