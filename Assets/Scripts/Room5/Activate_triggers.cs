using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_triggers : MonoBehaviour
{
  
    public GameObject trigger;
    public GameObject toOpen;
    Ray ray;
    bool once=false;

    private void Update()
    {

        if (trigger.GetComponent<Sign>().playerInRange == true && Input.GetMouseButtonDown(0))
        {
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit.collider != null)
            {
                
                if (hit.collider.gameObject.name == trigger.GetComponent<Sign>().obj.name &&once ==false)
                {
                    toOpen.SetActive(true);
                    once = true;
                }
            }
        }
    }
}
