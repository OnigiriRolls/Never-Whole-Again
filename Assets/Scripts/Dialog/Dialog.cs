using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject dialogBox;
    public PlayableDirector director;

    private void Start()
    {
        director.Pause();
        StartCoroutine(Type());
    }

    private void Update()
    {
        
        if(textDisplay.text==sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        dialogBox.SetActive(true);
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if(index<sentences.Length-1)
        {
            index++;
            textDisplay.text = "";
           // StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
        dialogBox.SetActive(false);
        director.Resume();
    }
   
}
