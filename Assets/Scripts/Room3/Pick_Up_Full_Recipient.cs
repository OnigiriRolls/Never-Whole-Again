using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pick_Up_Full_Recipient : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;//iti arat ce e
    private GameObject copy;

    Dontdestroy trans;

    GameObject objectManager;
    GameObject globalManager;

    bool state;

  

    private void Start()
    {//cand incepe jocul, punem in variabila innventory, inventarul jucatorului
        trans = GameObject.Find("TransitionItems").GetComponent<Dontdestroy>();
        inventory = GameObject.FindGameObjectWithTag("Player1").GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");
 
   
           
       
    }

    private void OnMouseDown()
    {
        
        //other== personajul care a intrat in raza obiectului
        if (GlobalManager.Instance.R3_fill_trigger == true)
        {//daca ala care a intrat e jucator si nu alt obiect random
         //facem for sa verificam in vectorul inventarului care slot e liber
           
            int i = GlobalManager.Instance.R3_Recipient_Index;
                
                    trans.full[i] = true;
                    //punem ca acuma ii ocupat slotu
                    inventory.isfull[i] = true;
                    //itemButton.gameObject.GetComponent<ItemState>().active = false;
                    itemButton.gameObject.GetComponent<ItemState>().Position = new Vector2(gameObject.transform.position.x,
                                                                 gameObject.transform.position.y);
                    // facem o copie a obiectului
                    copy = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Instantiate(itemButton, objectManager.gameObject.transform, false);

                    // globalManager.gameObject.transform.GetChild(globalManager.gameObject.transform.childCount - 1).name=
                    //   itemButton.GetComponent<Spawn>().item.name;
                    //o punem in inventar
                    GlobalManager.Instance.Recipient_full = true;
            
                    copy.transform.position = inventory.slots[i].transform.position;
                    //distrugem obiectul care a ramas pe mapa
                    //intr-un fel i am facut copy paste in inventar si o ramas originalul pe
                    //mapa, de aia trebe distrus
                    Destroy(gameObject);
                    //ii dam break, o data ce am gasit un slot liber pentru obiect n are rost sa mearga for-ul
                   
                
            
        }
    }
    


    
}
