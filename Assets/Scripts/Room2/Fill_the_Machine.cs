using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
public class Fill_the_Machine : MonoBehaviour
{

   
  
    GameObject player;
    Inventory inv;
    GameObject objectManager;
   // GameObject copy;

   // public GameObject recToSpawn;
    GameObject machToOpen;
    GameObject tentaclesClose;
    //GameObject sceneTrans;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player1");
        inv = player.GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");
        
    }

    

    public void Activate()
    {
        if (GlobalManager.Instance.R2_machine_trigger == true && GlobalManager.Instance.Recipient_full==true)
        {
            machToOpen = GameObject.Find("Room2_Opened_Machine");
           
           
            this.GetComponent<Image>().enabled = false;
            machToOpen.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            StartCoroutine("WaitTime");
        }
    }
    IEnumerator WaitTime()
    {
       // machToOpen = GameObject.Find("Room2_Opened_Machine");
        tentaclesClose = GameObject.Find("Tentacles");
        //sceneTrans = GameObject.Find("Scene_Transition_4");
       
        tentaclesClose.GetComponent<Animator>().enabled = true;
         yield return new WaitForSeconds(1.4f);
        for (int i = 0; i < inv.slots.Length; i++)
            if (inv.slots[i].transform.childCount > 0)
                if (inv.slots[i].transform.GetChild(0).gameObject.CompareTag("Filled"))
                {

                    Destroy(this.gameObject);
                    GameObject.Destroy(objectManager.transform.Find(this.name).gameObject);
                   // copy = Instantiate(recToSpawn, inv.slots[i].transform, false);
                  //  Instantiate(recToSpawn, objectManager.gameObject.transform, false);
                   // copy.transform.position = inv.slots[i].transform.position;
                   
                    GlobalManager.Instance.Recipient_full = false;
                    //machToOpen.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    
                    GlobalManager.Instance.R2_Room4_Open = true;
                    tentaclesClose.gameObject.SetActive(false);
                    break;
                }
        
      
    }


}
