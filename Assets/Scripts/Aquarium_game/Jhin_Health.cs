using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jhin_Health : MonoBehaviour
{
    public GameObject bars;
    
    GameObject boy;

    int i;
    public GameObject gameOver;

    public float air;
    

    void Start()
    {
      
        
        air = 11;     
        StartCoroutine("AirPass");
    }

    
    void Update()
    {
       
        if (air == 11)
        {
            bars.transform.GetChild(i).gameObject.SetActive(false);
            i = 0;
            bars.transform.GetChild(i).gameObject.SetActive(true);
        }
  
    }

  public IEnumerator AirPass()
    {
        while(air>0)
        {
            yield return new WaitForSeconds(0.5f);
            air = air - 0.5f;
            bars.transform.GetChild(i).gameObject.SetActive(false);
            i++;
            if(i<bars.transform.childCount)
            bars.transform.GetChild(i).gameObject.SetActive(true);
        }
        
        if (air==0 && GlobalManager.Instance.noHealth==false)
        {
            Time.timeScale = 0f;
            gameOver.gameObject.SetActive(true);
        }
    }
}
