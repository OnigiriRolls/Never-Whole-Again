using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bin_slider : MonoBehaviour
{
    public float timer;
    public string sign;
    public Text textBox1;

    void OnEnable()
    {
        timer = 5;
        this.GetComponent<Slider>().maxValue = 5;
        this.GetComponent<Slider>().value = 5;

        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        while(timer>0)
        {
            yield return new WaitForSeconds(1f);
            GetComponent<Slider>().value = GetComponent<Slider>().value - 1;
            timer = timer - 1;
        }

        textBox1.text = sign;
        this.gameObject.SetActive(false);

    }
}
