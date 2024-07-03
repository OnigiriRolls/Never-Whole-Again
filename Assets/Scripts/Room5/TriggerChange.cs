using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChange : MonoBehaviour
{

    public GameObject trigger;
    public GameObject toOpen;
   

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && trigger.GetComponent<Sign>().playerInRange==true)
        {
            RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition),
            new Vector3(0, 0, 1));
            for (int i = 0; i < hits.Length; i++)
                if (hits[i].collider != null)
                {
                    Debug.Log(hits[i].collider.name+" "+this.name);
                    if (hits[i].collider.name.Equals(this.name))
                        toOpen.SetActive(true);
                    break;
                }
            

        }
    }


}
