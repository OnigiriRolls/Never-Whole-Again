using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vault_check_numbers : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;

    public GameObject panel;
    public GameObject triggerDoor;
    public GameObject trigger;

    public GameObject DialogBox;
    public float timer;

    public GameObject dialogBox2;
    



    public void Check()
    {
        if(slot6.transform.childCount>0)
        {
            if (slot1.transform.GetChild(0).name.Equals("Number1(Clone)") && slot2.transform.GetChild(0).name.Equals("Number5(Clone)")
                && slot3.transform.GetChild(0).name.Equals("Number8(Clone)") &&
                slot4.transform.GetChild(0).name.Equals("Number8(Clone)") &&
                slot5.transform.GetChild(0).name.Equals("Number1(Clone)")
                && slot6.transform.GetChild(0).name.Equals("Number5(Clone)"))

            {
                GlobalManager.Instance.R5_door_open = true;
                DialogBox.SetActive(true);
                StartCoroutine("Loading");
            }
            else
            {
                dialogBox2.SetActive(true);

            }

        }
        
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(timer);
        triggerDoor.SetActive(true);
        trigger.SetActive(false);
        panel.SetActive(false);
    }
}
