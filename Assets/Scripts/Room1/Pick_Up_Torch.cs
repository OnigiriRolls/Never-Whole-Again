using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up_Torch : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;//iti arat ce e
    private GameObject copy;

    Dontdestroy trans;

    GameObject objectManager;
    GameObject globalManager;


    private void Start()
    {//cand incepe jocul, punem in variabila innventory, inventarul jucatorului
        trans = GameObject.Find("TransitionItems").GetComponent<Dontdestroy>();
        inventory = GameObject.FindGameObjectWithTag("Player1").GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");

    }

    private void  OnMouseDown()
    {

        if (GlobalManager.Instance.R1_wd_trigger== true)// && Input.GetMouseButtonDown(0))
        {

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isfull[i] == false)
                {
                    trans.full[i] = true;
                    //punem ca acuma ii ocupat slotu
                    inventory.isfull[i] = true;
                    //itemButton.gameObject.GetComponent<ItemState>().active = false;
                    itemButton.gameObject.GetComponent<ItemState>().Position = new Vector2(gameObject.transform.position.x,
                                                                 gameObject.transform.position.y);
                    // facem o copie a obiectului
                    copy = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Instantiate(itemButton, objectManager.gameObject.transform, false);
                    GlobalManager.Instance.torch_taken = true;
                    GlobalManager.Instance.torch_index = i;
                    // globalManager.gameObject.transform.GetChild(globalManager.gameObject.transform.childCount - 1).name=
                    //   itemButton.GetComponent<Spawn>().item.name;
                    //o punem in inventar
                    copy.transform.position = inventory.slots[i].transform.position;
                    //distrugem obiectul care a ramas pe mapa
                    //intr-un fel i am facut copy paste in inventar si o ramas originalul pe
                    //mapa, de aia trebe distrus
                    Destroy(gameObject);
                    //ii dam break, o data ce am gasit un slot liber pentru obiect n are rost sa mearga for-ul
                    break;
                }
            }
        }
    }

}
