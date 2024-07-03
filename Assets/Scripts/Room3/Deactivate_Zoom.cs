using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_Zoom : MonoBehaviour
{
    public Canvas magnifier;
   public void Deactivate()
    {
        magnifier.gameObject.SetActive(false);
    }
}
