using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine_Layer : MonoBehaviour
{
    public GameObject player;
    Vector3 pos;
    public float yaxe;
    public GameObject machine;

    private void Start()
    {
        yaxe = -1;
    }

    void Update()
    {
        
        pos = player.transform.position;
        if (pos.y > yaxe)
        {
            machine.GetComponent<SpriteRenderer>().sortingOrder = 1;
        }
        else
        {
            machine.GetComponent<SpriteRenderer>().sortingOrder = -1;
        }
    }
}
