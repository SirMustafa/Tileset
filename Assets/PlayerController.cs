using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hýzý
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movement.normalized * moveSpeed;
    }
}