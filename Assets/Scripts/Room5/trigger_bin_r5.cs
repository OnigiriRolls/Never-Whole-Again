using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger_bin_r5 : MonoBehaviour
{
    public Image img;
    public Text textBox;
    public Slider slid;
    public Text textBox1;
    public bool state;
    public GameObject bin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bin.GetComponent<PolygonCollider2D>().enabled = false;
        bin.GetComponent<PolygonCollider2D>().enabled = true;
        if (collision.tag == "Player1")
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

            slid.GetComponent<r5_Pick_up_greenwire>().StopAllCoroutines();
            slid.gameObject.SetActive(false);


            textBox1.gameObject.SetActive(false);

            img.gameObject.SetActive(false);

        }
    }
}
