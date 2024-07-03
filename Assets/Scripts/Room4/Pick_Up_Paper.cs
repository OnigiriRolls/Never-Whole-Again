using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up_Paper : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;//iti arat ce e
    private GameObject copy;

    Dontdestroy trans;

    GameObject objectManager;
    GameObject globalManager;

   // public GameObject couch;

    private void Start()
    {
        trans = GameObject.Find("TransitionItems").GetComponent<Dontdestroy>();
        inventory = GameObject.FindGameObjectWithTag("Player1").GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");

    }
    

    private void OnMouseDown()
    {
       
        if (this.GetComponentInParent <ItemState>().active == true)
        {
           
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isfull[i] == false)
                {
                    GlobalManager.Instance.paper_index = i;
                    GlobalManager.Instance.paper_picked = true;
                    trans.full[i] = true;
                  
                    inventory.isfull[i] = true;
             
                    itemButton.gameObject.GetComponent<ItemState>().Position = new Vector2(gameObject.transform.position.x,
                                                                 gameObject.transform.position.y);
                 
                    copy = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Instantiate(itemButton, objectManager.gameObject.transform, false);

                  
                    copy.transform.position = inventory.slots[i].transform.position;
                   
                    Destroy(gameObject);
                  
                    break;
                }
            }
        }
    }
    

    
}
