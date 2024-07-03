using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryScript : MonoBehaviour
{
    bool state;
    public string tagg;
    public GameObject player;
   public GameObject trans;
    Inventory inv;
  

    private void Start()
    {
        trans = GameObject.Find("TransitionItems");
        inv = player.GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
       
                if (this.CompareTag(obj.tag))
                {
                   
                    state = true;
            if (this.CompareTag("wire"))
                tagg = obj.name;
                }
       
        
    }

    private void Update()
    {
        if (state == true && GlobalManager.Instance.R5_press == true)
        {
            if (!this.CompareTag("wire"))
            {
                if (trans.transform.childCount>0)
            {
                for (int i = 0; i < trans.transform.childCount; i++)
                    if (trans.transform.GetChild(i).CompareTag(tagg))
                        GameObject.Destroy(trans.transform.GetChild(i).gameObject);
            }
            for (int i = 0; i < inv.slots.Length; i++)
                if(inv.slots[i].transform.childCount>0)
                if (inv.slots[i].transform.GetChild(0).gameObject.CompareTag(tagg))
                    GameObject.Destroy(inv.slots[i].transform.GetChild(0).gameObject);
           
                for (int i = 0; i < this.transform.childCount; i++)
                    if (this.transform.GetChild(i).CompareTag(tagg))
                        this.transform.GetChild(i).gameObject.SetActive(true);
                GlobalManager.Instance.nr++;
            }
            else
            {
                if (trans.transform.childCount > 0)
                {
                    for (int i = 0; i < trans.transform.childCount; i++)
                        if (trans.transform.GetChild(i).name.Equals(tagg))
                            GameObject.Destroy(trans.transform.GetChild(i).gameObject);
                }
                for (int i = 0; i < inv.slots.Length; i++)
                    if (inv.slots[i].transform.childCount > 0)
                        if (inv.slots[i].transform.GetChild(0).name.Equals(tagg))
                            GameObject.Destroy(inv.slots[i].transform.GetChild(0).gameObject);
                for (int i = 0; i < this.transform.childCount; i++)
                    if (this.transform.GetChild(i).name.Equals(tagg))
                        this.transform.GetChild(i).gameObject.SetActive(true);
                GlobalManager.Instance.nr++;
            }
           
           
        }
       
    }

    private void OnTriggerExit2D(Collider2D obj)
    {
       state = false;
    }



}
