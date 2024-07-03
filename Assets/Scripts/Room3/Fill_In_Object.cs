using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fill_In_Object : MonoBehaviour
{
 
   
    GameObject place_spawn;
    string toDestroy;
 

 GameObject player;
    Inventory inv;
    GameObject objectManager;
  

    private void Start()
    {
        
            player = GameObject.FindGameObjectWithTag("Player1");
            inv = player.GetComponent<Inventory>();
            objectManager = GameObject.Find("TransitionItems");
           
    }

    

    public void Fill()
    {
        if (GlobalManager.Instance.R3_fill_trigger == true)
        {

           
            if(this.gameObject.CompareTag("ToFill")==true)
            {
           
                place_spawn = GameObject.Find("Spawn_place");
                if (place_spawn.transform.childCount > 0)
                    place_spawn.transform.GetChild(0).gameObject.SetActive(true);
                toDestroy = this.name;
                this.GetComponent<Image>().enabled = false;
                GlobalManager.Instance.spawn_empty = true;
                StartCoroutine("WaitTime");
            

            }
        }
    }

    IEnumerator WaitTime()
    {
       
        yield return new WaitForSeconds(3f);
     
        foreach (Transform child in objectManager.transform)
        {
           
            if (child.name.CompareTo(toDestroy) == 0)
            {


                GameObject.Destroy(objectManager.transform.Find(this.name).gameObject);
                if (place_spawn.transform.childCount > 0)
                {
                    place_spawn.transform.GetChild(0).gameObject.SetActive(false);
                    place_spawn.transform.GetChild(1).gameObject.SetActive(true);
                    GlobalManager.Instance.spawn_full = true;
                }


                break;
            }
        }
        

        Destroy(this.gameObject);
    }

    
}
