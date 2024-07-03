using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_LastFuse : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;//iti arat ce e
    private GameObject copy;
    public GameObject player;
   
    public GameObject trigger;
 

    Dontdestroy trans;
    
    GameObject objectManager;
    GameObject globalManager;

   
    private void Start()
    {//cand incepe jocul, punem in variabila innventory, inventarul jucatorului
        trans = GameObject.Find("TransitionItems").GetComponent<Dontdestroy>();
        inventory = player.GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");

    }

   

    void OnMouseDown()
    {
        //other== personajul care a intrat in raza obiectului
        if (trigger.GetComponent<InSquare>().stateBoy==true)
        {//daca ala care a intrat e jucator si nu alt obiect random
         //facem for sa verificam in vectorul inventarului care slot e liber

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isfull[i] == false)
                {
                    trans.full[i] = true;
                    //punem ca acuma ii ocupat slotu
                    inventory.isfull[i] = true;
                    //itemButton.gameObject.GetComponent<ItemState>().active = false;

                    // facem o copie a obiectului
                    copy = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Instantiate(itemButton, objectManager.gameObject.transform, false);

                    // globalManager.gameObject.transform.GetChild(globalManager.gameObject.transform.childCount - 1).name=
                    //   itemButton.GetComponent<Spawn>().item.name;
                    //o punem in inventar
                    copy.transform.position = inventory.slots[i].transform.position;
                    //distrugem obiectul care a ramas pe mapa
                    //intr-un fel i am facut copy paste in inventar si o ramas originalul pe
                    //mapa, de aia trebe distrus
                   
                    //ii dam break, o data ce am gasit un slot liber pentru obiect n are rost sa mearga for-ul

                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

   
}
