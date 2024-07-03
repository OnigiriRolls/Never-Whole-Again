using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bin_activate_r5 : MonoBehaviour
{
    public Image img;
    public Text textBox;
    public Slider slid;
    public Text textBox1;
    public GameObject trigger;
    public string sign;

    private void OnMouseDown()
    {
        if (trigger.GetComponent<trigger_bin_r5>().state == true && slid.gameObject.activeSelf == false)
        {
            if (img.gameObject.activeSelf == false)
                img.gameObject.SetActive(true);
            if (textBox.gameObject.activeSelf == true)
                textBox.gameObject.SetActive(false);
            textBox1.text = sign;
            textBox1.gameObject.SetActive(true);

            slid.gameObject.SetActive(true);
        }
    }
}
