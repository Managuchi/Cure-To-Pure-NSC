using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 2;
    public float speed = 3f;
    public float lifeTime = 3f;

    public float distance = 0.1f;
    public LayerMask whatIsSolid;

    private void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        Debug.DrawLine(transform.position, transform.right * 100);
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            Debug.Log(hitInfo.collider.name);
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
