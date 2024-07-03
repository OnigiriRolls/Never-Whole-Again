using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Time_pass : MonoBehaviour
{
    public Text timeDisplay;
    public float timer;
    public float dialogTimer;
    public Image img;
    public GameObject[] dialogBox;
    public PlayableDirector cut_cutscene;
    public GameObject timePanel;
    public Animator panelAnim;
    public Animator textAnim;
    public GameObject[] toFalse;

    private void Start()
    {
        timeDisplay.text = timer.ToString();
        StartCoroutine("TimePass");
    }

    IEnumerator TimePass()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
            timeDisplay.text = timer.ToString();
            if (timer == 90f)
            {
                img.gameObject.SetActive(true);
                dialogBox[0].SetActive(true);
                panelAnim.SetBool("idle",true);
                textAnim.SetBool("idle", true);
                StartCoroutine(DialogTime(0));
            }
           else if(timer==60f)
            {
                img.gameObject.SetActive(true);
                dialogBox[1].SetActive(true);
                panelAnim.SetBool("idle", true);
                textAnim.SetBool("idle", true);
                StartCoroutine(DialogTime(1));
            }
            else if(timer==30f)
            {
                img.gameObject.SetActive(true);
                dialogBox[2].SetActive(true);
                panelAnim.SetBool("idle", true);
                textAnim.SetBool("idle", true);
                StartCoroutine(DialogTime(2));
            }
            else if(timer<6)
            {
                panelAnim.SetBool("idle", true);
                textAnim.SetBool("idle", true);
            }
        }

        if(timer==0)
        {
            for (int i = 0; i < toFalse.Length; i++)
                if(toFalse[i].activeSelf==true)
                toFalse[i].SetActive(false);
            panelAnim.SetBool("idle", false);
            textAnim.SetBool("idle", false);
            cut_cutscene.GetComponent<PlayableDirector>().enabled = true;
            cut_cutscene.GetComponent<Timeline_Manager_cut>().enabled = true;
            timePanel.SetActive(false);
        }
    }

    IEnumerator DialogTime(int index)
    {
        yield return new WaitForSeconds(dialogTimer);
        dialogBox[index].SetActive(false);
        img.gameObject.SetActive(false);
        panelAnim.SetBool("idle", false);
        textAnim.SetBool("idle", false);
       
    }
}
