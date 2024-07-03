using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Update_energy : MonoBehaviour
{
    private void OnDisable()
    {
        gameObject.SetActive(false);
    }
}
