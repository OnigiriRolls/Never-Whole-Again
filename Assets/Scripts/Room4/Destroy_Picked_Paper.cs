using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Picked_Paper : MonoBehaviour
{
    void Start()
    {
        if (GlobalManager.Instance.paper_picked == true)
            Destroy(this.gameObject);

    }
}
