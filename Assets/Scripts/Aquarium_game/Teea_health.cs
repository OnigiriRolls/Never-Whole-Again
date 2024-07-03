using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teea_health : MonoBehaviour
{
    public Slider healthBar;
    public float health;

    void Awake()
    {
        health = 100f;
        healthBar.value = health;
    }

    
    void Update()
    {
        if (healthBar.value != health)
            healthBar.value = health;
    }
}
