using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;

    public event System.Action OnPlayerDied;

    private void Update()
    {
        if (health <= 0)
        {
            OnPlayerDied?.Invoke();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
