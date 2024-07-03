using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_wave : MonoBehaviour
{
    
    public GameObject[] fish;
    
    int i=0;

    public void Change()
    {
        fish[i].layer = 9;
        fish[i+1].layer = 9;
        i = i + 2;
    }

    /*/
   public void restart()
    {
        for(int i=0;i<fish.Length;i++)
        {
            fish[i].GetComponent<SpriteRenderer>().enabled = true;
            fish[i].transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    /*/
}
