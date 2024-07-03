using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_bullet : MonoBehaviour
{
    float moveSpeed = 3f;
    Rigidbody2D rb;
  Swim target;
 
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Swim>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);

    }

  
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name.Equals("Jhin"))
        {
            this.tag = "fish";
            GetComponent<SpriteRenderer>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
        }
        

    }
  
}
