using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_with_Teea : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float speed = 20;

    public Animator animator;

    void Start()
    {
       rb2 = GetComponent<Rigidbody2D>();
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

        Vector2 position = rb2.position;
        position.x = position.x + 0.1f * horizontal2 * Time.deltaTime * speed;
        position.y = position.y + 0.1f * vertical2 * Time.deltaTime * speed;
        rb2.MovePosition(position);

    }
}
