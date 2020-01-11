using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria01 : MonoBehaviour
{
    public int damage = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Okay");
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Player>().TakeDamage(damage);
        }
    }
}
