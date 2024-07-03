using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float speed = 20;
    public Animator animator;

    private void Start()
    {
        animator.SetBool("swim", true);
    }

    void Update()
    {

        float horizontal2 = 0;
        float vertical2 = 0;   

        horizontal2 = Input.GetAxis("Horizontal");
        vertical2 = Input.GetAxis("Vertical");

        if (Input.GetAxis("Horizontal") == 0)
            animator.SetBool("Hor", false);
        else animator.SetBool("Hor", true);

        if (Input.GetAxis("Vertical") == 0)
            animator.SetBool("Ver", false);
        else animator.SetBool("Ver", true);

        animator.SetFloat("Horizontal1", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical1", Input.GetAxis("Vertical"));


        Vector2 position = rb.position;
        position.x = position.x + 0.1f * horizontal2 * Time.deltaTime * speed;
        position.y = position.y + 0.1f * vertical2 * Time.deltaTime * speed;
        rb.MovePosition(position);

    }

    private void OnDisable()
    {
        animator.SetBool("swim", false);
    }
}
