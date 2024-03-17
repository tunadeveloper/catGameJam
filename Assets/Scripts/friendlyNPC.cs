using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendlyNPC : MonoBehaviour
{
    public Transform target; // Dostlar�m�z�n kimi takip etti�ini g�stermek i�in
    public float speed = 3f; // Minno� dostlar�m�z i�in takip h�z�
    public float stoppingDistance = 2f; // Herkes �st �ste gelememeli dimi :D

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target != null)
        {
            // NPC'nin karaktere do�ru hareket etmesi i�in gerekli vekt�rc�klerim
            Vector2 direction = new Vector2 ((target.position.x - transform.position.x), transform.position.y).normalized;

            // NPC'nin karakterin �n�nde durmas� i�in gerekli mesafeyi koruma kalkan�
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
            {
                // Minno�lar�n hareketi
                rb.velocity = direction * speed;
            }
            else
            {
                // Dur i�te :D
                rb.velocity = Vector2.zero;
            }

            if (direction.x < 0 && facingRight)
            {
                Flip();
            }

            else if (direction.x > 0 && !facingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
