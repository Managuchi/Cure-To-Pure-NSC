using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Rigidbody2D rb;
    Transform target;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = FindObjectOfType<Player>().transform;
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            rb.position = Vector2.MoveTowards(rb.position, target.position, speed * Time.fixedDeltaTime);
        }
    }
}
