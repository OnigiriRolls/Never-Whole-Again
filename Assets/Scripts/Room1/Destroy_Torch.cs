using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Torch : MonoBehaviour
{
    void Start()
    {
        if (GlobalManager.Instance.torch_taken == true)
            Destroy(this.gameObject);

    }
}
