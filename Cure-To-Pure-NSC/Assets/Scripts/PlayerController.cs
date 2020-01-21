﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    Vector2 velocity;
    Rigidbody2D rb;

    public int dashSpeed;
    private float dashTime;
    public float startDashTime;

    bool isFacingRight = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        dashTime = startDashTime;
    }

    private void Update()
    {
        Vector2 dir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if (angle > -90f && angle < 90f && !isFacingRight)
        {
            Flip();
        }
        else if ((angle > 90f || angle < -90f) && isFacingRight)
        {
            Flip();
        }

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        velocity = input.normalized * speed;

        if (dashTime <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = dir * dashSpeed;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
