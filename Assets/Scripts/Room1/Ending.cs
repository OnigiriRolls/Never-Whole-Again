using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Ending : MonoBehaviour
{
    public GameObject inventory;
    public GameObject timeline;
    public bool state;
    public Animator animator;
    Inventory inv;
    public GameObject player;
     GameObject obj;

    private void Start()
    {
        obj = GameObject.Find("TransitionItems");
        inv = player.GetComponent<Inventory>();
        this.GetComponent<Animator>().enabled = false;
    }

    void Update()
    {
        if(GlobalManager.Instance.screwdriver_taken==true)
        {
            animator.enabled = true;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1") && GlobalManager.Instance.screwdriver_taken == true)
        {
            
            animator.SetBool("enabled", true);
            timeline.GetComponent<PlayableDirector>().enabled = true;
            for(int i=0;i<inv.slots.Length;i++)
                if(inv.slots[i].transform.childCount>0)
                Destroy(inv.slots[i].transform.GetChild(0).gameObject);
            
            foreach (Transform child in obj.transform)           
                {
                    Destroy(child.gameObject);
                }

            inventory.SetActive(false);
            state = true;      
        }
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
            state = false;
    }
}
