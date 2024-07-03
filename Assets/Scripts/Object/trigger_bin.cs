using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger_bin : MonoBehaviour
{
    public Image img;
    public Text textBox;
    public Slider slid;
    public Text textBox1;
    public bool state;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player1")
        {
            state = true;
            img.gameObject.SetActive(true);
            textBox.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            state = false;

            textBox.gameObject.SetActive(false);
           
                slid.GetComponent<Bin_slider>().StopAllCoroutines();
                slid.gameObject.SetActive(false);
            
            
                textBox1.gameObject.SetActive(false);
            
                img.gameObject.SetActive(false);

        }
    }

}
