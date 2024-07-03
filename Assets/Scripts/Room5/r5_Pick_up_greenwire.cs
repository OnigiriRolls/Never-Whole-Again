using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class r5_Pick_up_greenwire : MonoBehaviour
{
    public float timer;
    public string sign;
    public Text textBox1;
    int i = 0;
    private Inventory inventory;
    public GameObject itemButton;//iti arat ce e
    private GameObject copy;
    public GameObject player;
    Dontdestroy trans;

    GameObject objectManager;
    GameObject globalManager;

    public GameObject trigger;

    // public GameObject couch;

    private void Start()
    {
        trans = GameObject.Find("TransitionItems").GetComponent<Dontdestroy>();
        inventory = player.GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");

    }


    void OnEnable()
    {
        timer = 5;
        this.GetComponent<Slider>().maxValue = 5;
        this.GetComponent<Slider>().value = 5;
        if (i == 0)
            sign = "You found a wire";
        else sign = "Nothing found";

        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        while (timer > 0)
        {
           
            yield return new WaitForSeconds(1f);
            GetComponent<Slider>().value = GetComponent<Slider>().value - 1;
            timer = timer - 1;
        }

        textBox1.text = sign;

        if (i == 0)
        {
            i++;
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isfull[i] == false)
                {

                    trans.full[i] = true;

                    inventory.isfull[i] = true;

                    //itemButton.gameObject.GetComponent<ItemState>().Position = new Vector2(gameObject.transform.position.x,
                    //                                           gameObject.transform.position.y);

                    copy = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Instantiate(itemButton, objectManager.gameObject.transform, false);


                    copy.transform.position = inventory.slots[i].transform.position;



                    break;
                }
            }
        }

        this.gameObject.SetActive(false);

    }

    

   
}
