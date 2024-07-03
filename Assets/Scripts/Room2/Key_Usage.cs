using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Key_Usage : MonoBehaviour
{
    bool state;
    Inventory inv;

    public GameObject toOpen;
    public GameObject player;

    public GameObject key_button;
    GameObject key;
    GameObject trans;

    private void Start()
    {
        trans = GameObject.Find("TransitionItems");
        inv = player.GetComponent<Inventory>();
        if (GlobalManager.Instance.Recipient_empty == true)
        { toOpen.SetActive(true);
            this.gameObject.SetActive(false);
            if (toOpen.transform.childCount > 0)
                GameObject.Destroy(toOpen.transform.GetChild(0).gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
            state = true;
    }
  
    private void Update()
    { 
        if (state == true && GlobalManager.Instance.keyState == true)
        {
            if (key.GetComponent<ItemState>().active == true)
            {
                toOpen.SetActive(true);
                if (trans.transform.childCount > 0)
                {
                    foreach (Transform child in trans.transform)
                        if (key.name.Equals(child.name))
                        {
                            Destroy(child.gameObject);
                            break;
                        }
                }

                Destroy(key.gameObject);
                this.gameObject.SetActive(false);
            }
        }
        else if (state != true && GlobalManager.Instance.keyState == true)
        {
            for (int i = 0; i < inv.slots.Length; i++)
                if (inv.slots[i].transform.childCount > 0)
                    if (inv.slots[i].transform.GetChild(0).name.Equals(key_button.name + "(Clone)"))
                    {
                        key = inv.slots[i].transform.GetChild(0).gameObject;
                        break;
                    }

            key.GetComponent<ItemState>().active = false;

        }
    }
       


        private void OnTriggerExit2D(Collider2D player)
        {
           
            if (player.CompareTag("Player1") )
            {
              state = false;
            }

        }
    }

