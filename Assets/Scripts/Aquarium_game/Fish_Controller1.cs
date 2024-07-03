using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Controller1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 move;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        move.x = transform.position.x + 0.1f * (transform.position.x + 10f) * Time.deltaTime * speed;
        move.y = transform.position.y;
        rb.MovePosition(move);
    }

}
