using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickedObject : MonoBehaviour
{


    void Start()
    {
        if (GlobalManager.Instance.Recipient_empty == true)
            Destroy(this.gameObject);
        
    }

   
}
