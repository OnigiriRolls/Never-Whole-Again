using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart_3rdWave : MonoBehaviour
{
    GameObject fish;
    public Vector2 pos;
    public GameObject effect;

    public void Restart()
    {
        fish = transform.GetChild(1).gameObject;
        fish.transform.localPosition= pos;
        fish.SetActive(true);
        effect.SetActive(false);
        
    }
}
