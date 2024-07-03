using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUsage2 : MonoBehaviour
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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player1"))
        { state = true; }
/*/
            if (GlobalManager.Instance.key_taken == true)
            {
               
                for (int i = 0; i < inv.slots.Length; i++)
                    if (inv.slots[i].transform.childCount > 0)
                        if (inv.slots[i].transform.GetChild(0).name.Equals(key_button.name + "(Clone)"))
                        {
                            key = inv.slots[i].transform.GetChild(0).gameObject;
                            break;
                        }
              
                Debug.Log(key.name);
            }


        }
  /*/
    }
  
    private void Update()
    {
        if (state == true && GlobalManager.Instance.key_taken == true)
        { if (key.GetComponent<ItemState>().active == true)
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
        else if(state != true && GlobalManager.Instance.key_taken == true)
        {
            for (int i = 0; i < inv.slots.Length; i++)
                if (inv.slots[i].transform.childCount > 0)
                    if (inv.slots[i].transform.GetChild(0).name.Equals(key_button.name + "(Clone)"))
                    {
                        key = inv.slots[i].transform.GetChild(0).gameObject;
                        break;
                    }
            Debug.Log(key.name);
            key.GetComponent<ItemState>().active = false;

        }

    }



    private void OnTriggerExit2D(Collider2D player)
    {

        if (player.CompareTag("Player1"))
        {
            state = false;
        }

    }
}
