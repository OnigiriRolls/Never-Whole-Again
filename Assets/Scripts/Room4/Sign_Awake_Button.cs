using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign_Awake_Button : MonoBehaviour
{
    public GameObject dialogBox1;
    Text dialogText1;
    public string dialog1;
    public float timer1;

    private void Start()
    {
        dialogBox1 = GameObject.Find("Sign").transform.GetChild(0).gameObject;
        dialogText1=dialogBox1.transform.GetChild(0).gameObject.GetComponent<Text>();
    }

    public void Sign()
    {
       
            StopAllCoroutines();
           
            dialogBox1.SetActive(true);
            dialogText1.text = dialog1;
            StartCoroutine("Timer1");
       
    }

    IEnumerator Timer1()
    {
        if (dialogBox1.activeSelf == false)         
            {         
                yield return 0;
            }
            else
            {
                yield return new WaitForSeconds(timer1);
                dialogBox1.SetActive(false);
            }
      
    }
    private void OnDisable()
    {
        if (dialogBox1 != null )
            if(dialogBox1.activeSelf == true)
            dialogBox1.SetActive(false);
    }

}
