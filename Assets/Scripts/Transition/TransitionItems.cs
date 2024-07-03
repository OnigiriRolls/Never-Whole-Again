using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionItems : MonoBehaviour
{
    Inventory inv;
    GameObject trans;
    GameObject copy;
    Dontdestroy transScript;

    private void Awake()
    {
        trans = GameObject.Find("TransitionItems");
        transScript = trans.GetComponent<Dontdestroy>();
        if (trans.transform.childCount > 0)
        {
            
            inv = this.GetComponent<Inventory>();
            int d = 0,j;         

            for (j = 0; j < inv.slots.Length; j++)
                if(transScript.full[j]==true)
            {

                //inv.slots[d] = trans.gameObject.transform.GetChild(d).gameObject;

                inv.isfull[j] = true;
                copy = Instantiate(trans.gameObject.transform.GetChild(d).gameObject, inv.slots[j].transform, false);
                inv.slots[j].transform.GetChild(0).name = trans.gameObject.transform.GetChild(d).name;
                copy.transform.position = inv.slots[j].transform.position;
                    d++;

            }
        }
    }
  
}
