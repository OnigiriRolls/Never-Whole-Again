using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_credits : MonoBehaviour
{
    public Image img;
    public Button button;
    public Text[] pieces;
    int i;

    private void Start()
    {   
        StartCoroutine(Time());
    }
    
    IEnumerator Time()
    {
        if (i < pieces.Length)
        {
            pieces[i].gameObject.SetActive(true);
            while (pieces[i].GetComponent<Text>().enabled == true)
                yield return null;
            pieces[i].gameObject.SetActive(false);
            i++;
            StartCoroutine(Time());
        }
        else
        {
            StopAllCoroutines();
            img.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
        }
    }


}
