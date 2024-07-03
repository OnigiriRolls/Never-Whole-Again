using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health_bar_change : MonoBehaviour
{
    public GameObject bars;
    int i = 0;
    public GameObject boy;


    void Update()
    {
       

            if (boy.GetComponent<Jhin_Health>().air == 100)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i = 0;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 100)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 96)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 91)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 86)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 81)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 76)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 71)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 66)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 61)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 56)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 51)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 46)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 41)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 36)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 31)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 26)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 21)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 16)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 11)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air < 6)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
            else if (boy.GetComponent<Jhin_Health>().air == 1)
            {
                bars.transform.GetChild(i).gameObject.SetActive(false);
                i++;
                bars.transform.GetChild(i).gameObject.SetActive(true);
            }
        

    }

}
