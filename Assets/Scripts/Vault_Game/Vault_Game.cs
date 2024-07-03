using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vault_Game : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject DialogBox;
    public Text DialogText;
    public string dialog;
    public string dialog1;
   

    
    

    public GameObject op;

    public void Check()
    {
        if(slot4.transform.childCount>0)
        {
           
            if (slot1.transform.GetChild(0).name.Equals("Number2(Clone)") &&
                slot2.transform.GetChild(0).name.Equals("Number6(Clone)") &&
                slot3.transform.GetChild(0).name.Equals("Number0(Clone)") &&
                slot4.transform.GetChild(0).name.Equals("Number8(Clone)"))
            {              
                op.gameObject.SetActive(true);                        
            }
            
                else
            { DialogBox.SetActive(true);
                DialogText.text = dialog1;
                DialogBox.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }


}
