using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_controller : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
   
    void Update()
    {
        rb.AddForce((-1) * transform.right* speed);
    }

    
}
