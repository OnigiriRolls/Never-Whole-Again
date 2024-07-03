using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    GameObject trans;
    Dontdestroy transScript;
    GameObject player;
    GameObject boy;
    GameObject objectManager;

    private void Start()
    {
        trans = GameObject.Find("TransitionItems");


        boy = GameObject.Find("Jhin");
        if (boy != null)
            player = boy;
        else player = GameObject.FindGameObjectWithTag("Player1");
        inventory = player.GetComponent<Inventory>();
        transScript = trans.GetComponent<Dontdestroy>();
        objectManager = GameObject.Find("TransitionItems");
    }

    void Update()
    {
      if(transform.childCount<=0)
        {
            inventory.isfull[i] = false;
            transScript.full[i] = false;
        }
      
    }

   
}
