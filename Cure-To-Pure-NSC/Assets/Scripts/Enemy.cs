﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;

    public int health = 10;
    public int damage = 1;

    public float flashTime = .1f;

    Material defaultMat;
    Material whiteMat;
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        defaultMat = sr.material;
        whiteMat = Resources.Load<Material>("whiteFlash");
    }

    private void Update()
    {
        if (health <= 0)
        {
            Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Player>().TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        sr.material = whiteMat;
        Invoke("resetMaterial", flashTime);
    }

    private void resetMaterial()
    {
        sr.material = defaultMat;
    }

    private void Death()
    {
        Destroy(gameObject);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }
}
