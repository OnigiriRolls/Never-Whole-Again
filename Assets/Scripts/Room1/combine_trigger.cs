using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combine_trigger : MonoBehaviour
{
    int j;
    bool state;
    public string tagg;
    string name1;
   GameObject trans;
    Inventory inv;
    public GameObject toSpawn;
    GameObject copy;

    private void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Player1").GetComponent<Inventory>();
        trans = GameObject.Find("TransitionItems");
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (this.CompareTag(obj.tag))
        {
            name1 = obj.name;
            state = true;
          
        }

    }

    private void Update()
    {
        if (state == true && GlobalManager.Instance.R5_press == true)
        {
            
            
                if (trans.transform.childCount > 0)
                {
                    for (int i = 0; i < trans.transform.childCount; i++)
                        if (trans.transform.GetChild(i).CompareTag(tagg))
                            GameObject.Destroy(trans.transform.GetChild(i).gameObject);
                }
            for (int i = 0; i < inv.slots.Length; i++)
                if (inv.slots[i].transform.childCount > 0)
                    if (inv.slots[i].transform.GetChild(0).gameObject.CompareTag(tagg))
                    {
                        //if (!inv.slots[i].transform.GetChild(0).gameObject.name.Equals(name))
                             j = i;

                            GameObject.Destroy(inv.slots[i].transform.GetChild(0).gameObject);
                    }
            inv.isfull[j] = true;
          

            
            copy = Instantiate(toSpawn, inv.slots[j].transform, false);
            Instantiate(toSpawn, trans.gameObject.transform, false);

           
            copy.transform.position = inv.slots[j].transform.position;


        }
    }

    private void OnTriggerExit2D(Collider2D obj)
    {
        state = false;
    }
}
